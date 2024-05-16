using ControlApp.Core.Entities;
using ControlApp.Interfaces;

namespace ControlApp.UserControls;

public partial class SalesDetails : UserControl, IEntityUserControl<ProductSaleEntity>
{
    private readonly IProductsRepository _productsRepository;

    public SalesDetails()
    {
        InitializeComponent();
    }

    public SalesDetails(IProductsRepository productsRepository)
        :this()
    {
        this._productsRepository = productsRepository;
        this.Load += SalesDetails_Load;
    }

    private async void SalesDetails_Load(object? sender, EventArgs e)
    {

        var products = await _productsRepository.GetProducts();
        productsBs.DataSource = products;

        if (Entity.Id == 0 && products.Count > 0)
        {
            Entity.ProductId = products.First().Id;
        }
        else
        {
            Entity.ProductId = Entity.ProductId;
        }
    }

    public ProductSaleEntity Entity { get; private set; }

    public void SetupEntity(ProductSaleEntity entity)
    {
        mainBs.DataSource = entity;
        Entity = entity;
    }
}
