using ControlApp.Core.Entities;
using ControlApp.Interfaces;

namespace ControlApp.UserControls;

public partial class ProductReturnDetails : UserControl, IEntityUserControl<ProductReturnEntity>
{
    private readonly IProductsRepository _productsRepository;

    public ProductReturnDetails()
    {
        InitializeComponent();
        this.Load += ProductReturnDetails_Load;
    }

    public ProductReturnDetails(IProductsRepository productsRepository)
        :this()
    {
        this._productsRepository = productsRepository;
    }

    private async void ProductReturnDetails_Load(object? sender, EventArgs e)
    {

        var products = await _productsRepository.GetProducts();
        productsBs.DataSource = products;

        if (Entity.Id == 0 && products.Count > 0)
        {
            Entity.ProductId = products.First().Id;
        }
    }

    public ProductReturnEntity Entity { get; private set; }

    public void SetupEntity(ProductReturnEntity entity)
    {
        mainBs.DataSource = entity;
        Entity = entity;
    }
}
