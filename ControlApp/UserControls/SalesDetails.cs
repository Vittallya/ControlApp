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
    private int previewProductId;
    private int previewSelled;

    public async void SetupEntity(ProductSaleEntity entity)
    {
        var products = await _productsRepository.GetProducts();
        productsBs.DataSource = products;
        mainBs.DataSource = entity;
        Entity = entity;
        previewProductId = entity.ProductId;
        previewSelled = entity.Count;

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

        var productsCount = Entity.Product.Count;
        var newProductCount = productsCount - Entity.Count;

        if (Entity.Id > 0)
        {
            if(Entity.ProductId != previewProductId)
            {
                var previewProduct = await _productsRepository.GetById(previewProductId);
                await _productsRepository.UpdateProductCount(previewProductId, previewProduct!.Count + previewSelled);
            }
            else
            {
                newProductCount = Entity.Count + previewSelled - Entity.Count;
            }

        }
        await _productsRepository.UpdateProductCount(Entity.ProductId, newProductCount);
        return true;
    }
}
