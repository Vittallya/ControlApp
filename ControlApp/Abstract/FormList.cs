using ControlApp.Core.Entities;
using ControlApp.Extensions;
using ControlApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ControlApp.Abstract;

//public partial class FormList : Form
public partial class FormList<TEntity> : Form
    where TEntity : IEntity, new()
{
    private readonly IGenericRepository<TEntity> _repository;
    private readonly IEntityListUserControl<TEntity> _userControl;

    public FormList()
    {
        InitializeComponent();
    }

    public FormList(
        IGenericRepository<TEntity> repository
      , IEntityListUserControl<TEntity> userControl)
        : this()
    {
        this._repository = repository;
        this._userControl = userControl;
        this.Load += FormList_Load;
        panel1.Controls.Add((Control)_userControl);
    }

    private async void FormList_Load(object? sender, EventArgs e)
    {
        await Reload();
    }

    private async Task Reload()
    {
        var list = await _repository.GetAllItems("Product");
        _userControl.SetupDataSource(list);
    }

    private async void button2_Click(object sender, EventArgs e)
    {
        var detailForm = Program.ServiceProvider.GetRequiredService<DetailForm>();
        detailForm.SetupForEntity(new TEntity());

        if (detailForm.ShowDialog() == DialogResult.OK)
        {
            await _repository.AddItem((TEntity)detailForm.Entity);
            await Reload();
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        this.ChangeForm<MainForm>();
    }

    private async void OnEditClick(object sender, EventArgs e)
    {
        if (_userControl.SelectedCount > 0)
        {
            var selected = _userControl.SelectedEntities.First();
            var detailForm = Program.ServiceProvider.GetRequiredService<DetailForm>();
            detailForm.SetupForEntity(selected);

            if (detailForm.ShowDialog() == DialogResult.OK)
            {
                await _repository.UpdateItem((TEntity)detailForm.Entity);
                await Reload();
            }
        }
    }

    private async void OnDeleteItemClicked(object sender, EventArgs e)
    {

        if (_userControl.SelectedCount > 0)
        {
            var isConfirmed = MessageBox
                .Show($"Подтвердить удаление объектов ?({_userControl.SelectedCount})", 
                "", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes;

            if(isConfirmed)
            {
                var ids = _userControl
                    .SelectedEntities.Select(item => item.Id)
                    .ToArray();

                await _repository.DeleteItems(ids);
                await Reload();
            }
        }
    }
}
