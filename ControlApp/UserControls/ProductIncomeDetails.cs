using ControlApp.Core.Entities;
using ControlApp.Interfaces;

namespace ControlApp.UserControls;

public partial class ProductIncomeDetails : UserControl, IEntityUserControl<ProductIncomeEntity>
{
    private readonly IProductsRepository _productsRepository = null!;

    public ProductIncomeEntity Entity { get; private set; } = null!;

    public ProductIncomeDetails()
    {
        InitializeComponent();
        this.Load += ProductIncomeDetails_Load;
    }

    public ProductIncomeDetails(IProductsRepository productsRepository)
        : this()
    {
        this._productsRepository = productsRepository;
    }

    private async void ProductIncomeDetails_Load(object? sender, EventArgs e)
    {
        var products = await _productsRepository.GetProducts();
        productsBs.DataSource = products;

        if(Entity.Id == 0 && products.Count > 0)
        {
            Entity.ProductId = products.First().Id;
        }
    }

    public void SetupEntity(ProductIncomeEntity entity)
    {
        Entity = entity;
        ProductIncomeBs.DataSource = entity;
    }
}
