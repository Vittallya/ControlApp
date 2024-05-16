using ControlApp.Abstract;
using ControlApp.Core.Entities;

namespace ControlApp;

public partial class ProductsIncomeForm : Form
{
    private readonly IGenericRepository<ProductIncomeEntity> _repository = null!;

    public ProductsIncomeForm()
    {
        InitializeComponent();
        this.Load += OnFormLoaded;
    }

    public ProductsIncomeForm(IGenericRepository<ProductIncomeEntity> repository)
        :this()
    {
        _repository = repository;
    }

    private async void OnFormLoaded(object? sender, EventArgs e)
    {
        var productIncomes = await _repository.GetAllItems("Product");
        dataGridView1.DataSource = productIncomes;
    }
}
