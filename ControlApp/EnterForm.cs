using ControlApp.Core.Services.Interfaces;
using ControlApp.Extensions;
using ControlApp.ViewModels;

namespace ControlApp;

public partial class EnterForm : Form
{
    private readonly ILoginService _loginService = null!;

    public EnterForm()
    {
        InitializeComponent();
    }

    public EnterForm(ILoginService loginService)
        : this()
    {
        loginViewModel.DataSource = new LoginViewModel();
        this._loginService = loginService;
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        button1.Enabled = false;
        await Login();
        button1.Enabled = true;
    }

    private async Task Login(CancellationToken cancellationToken = default)
    {
        var vm = (LoginViewModel)loginViewModel.DataSource;

        if (!string.IsNullOrEmpty(vm.Login))
        {
            var userId = await _loginService.TryGetUserId(vm.Login, cancellationToken);

            if (userId == null)
            {
                MessageBox.Show("Пользователь не найден по логину!", "Система", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (vm.Password != null
                && await _loginService.IsPasswordCorrect(userId.Value, vm.Password, cancellationToken))
            {
                this.ChangeForm<MainForm>("Главная");
                this.Close();
                return;
            }
        }

        MessageBox.Show("Логин или пароль введены неверно!", "Система", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private async void EnterForm_KeyDown(object sender, KeyEventArgs e)
    {
        if(e.KeyCode == Keys.Enter)
        {
            button1.Enabled = false;
            await Login();
            button1.Enabled = true;
        }
    }
}
