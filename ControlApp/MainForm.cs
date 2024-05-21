using ControlApp.Abstract;
using ControlApp.Core.Entities;
using ControlApp.Core.Interfaces;
using ControlApp.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace ControlApp;

public partial class MainForm : Form
{
    private readonly IReportService _reportService;
    private readonly IProductsRepository _productsRepository;

    public MainForm()
    {
        InitializeComponent();
    }

    public MainForm(IReportService reportService, IProductsRepository productsRepository)
        : this()
    {
        this._reportService = reportService;
        this._productsRepository = productsRepository;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        this.ChangeForm<ProductsForm>();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        this.ChangeForm<FormList<ProductIncomeEntity>>("Поступления товаров");
    }

    private void button3_Click(object sender, EventArgs e)
    {
        this.ChangeForm<FormList<ProductReturnEntity>>("Возвраты товаров");
    }

    private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.ChangeForm<EnterForm>("Вход");
    }

    private void button4_Click(object sender, EventArgs e)
    {
        this.ChangeForm<FormList<ProductSaleEntity>>("Продажи");
    }

    private async void button5_Click(object sender, EventArgs e)
    {
        await CreateProductReport();
    }

    private async Task CreateReport<T>()
        where T : IEntity
    {
        using var filePathForm = new SaveFileDialog()
        {
            FileName = "report.docx",
            CheckFileExists = false,
            AddExtension = true,
            CheckPathExists = true,
        };

        if (filePathForm.ShowDialog() == DialogResult.OK)
        {
            var repository = Program.ServiceProvider.GetRequiredService<IGenericRepository<T>>();
            var entities = await repository.GetAllItems();
            var path = filePathForm.FileName;
            _reportService.CreateReport(entities, path);
        }
    }

    private async Task CreateProductReport()
    {
        using var filePathForm = new SaveFileDialog()
        {
            FileName = "report.docx",
            CheckFileExists = false,
            AddExtension = true,
            CheckPathExists = true,
        };

        if (filePathForm.ShowDialog() == DialogResult.OK)
        {
            var entities = await _productsRepository.GetProducts();
            var path = filePathForm.FileName;
            _reportService.CreateReport(entities, path);
        }
    }

    private async void button7_Click(object sender, EventArgs e)
    {
        await CreateReport<ProductIncomeEntity>();
    }

    private async void button8_Click(object sender, EventArgs e)
    {
        await CreateReport<ProductSaleEntity>();
    }

    private async void button9_Click(object sender, EventArgs e)
    {
        await CreateReport<ProductReturnEntity>();
    }
}
