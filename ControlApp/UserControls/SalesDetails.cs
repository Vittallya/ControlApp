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
    }

    public ProductSaleEntity Entity { get; private set; }

    public async void SetupEntity(ProductSaleEntity entity)
    {
        var products = await _productsRepository.GetProducts();
        productsBs.DataSource = products;
        mainBs.DataSource = entity;
        Entity = entity;

        if(entity.Id == 0)
        {
            Entity.Product = products.First();
        }

    }
    public async Task<bool> PostProcess()
    {
        if(Entity.Count > Entity.Product!.Count)
        {
            MessageBox.Show("Указанное количество проданного товара больше, чем по факту имеется");
            return false;
        }

        Entity.TotalSum = Entity.Product!.Cost * Entity.Count;
        Entity.ProductId = Entity.Product!.Id;
        await _productsRepository.UpdateProductCount(Entity.ProductId, -Entity.Count);
        return true;
    }
}
