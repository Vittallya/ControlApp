using ControlApp.Core.Entities;
using ControlApp.Infrastructure.Models;
using ControlApp.Interfaces;

namespace ControlApp.UserControls;

public partial class ProductIncomeDetails : UserControl, IEntityUserControl<ProductIncomeEntity>
{
    private readonly IProductsRepository _productsRepository = null!;
    private IReadOnlyCollection<ProductEntity> _products;
    public ProductIncomeEntity Entity { get; private set; } = null!;

    public ProductIncomeDetails()
    {
        InitializeComponent();
    }

    public ProductIncomeDetails(IProductsRepository productsRepository)
        : this()
    {
        this._productsRepository = productsRepository;
    }

    private int previewProductId;
    private int previewCount;

    public async void SetupEntity(ProductIncomeEntity entity)
    {

        _products = await _productsRepository.GetProducts();
        productsBs.DataSource = _products;
        Entity = entity;
        previewProductId = entity.ProductId;
        previewCount = entity.Count;
        ProductIncomeBs.DataSource = entity;
        if (entity.Id == 0)
        {
            Entity.ProductEntity = _products.First();
        }
    }

    public async Task<bool> PostProcess()
    {
        Entity.TotalSum = Entity.Count * Entity.ProductEntity!.Cost;
        Entity.ProductId = Entity.ProductEntity!.Id;

        var productsCount = Entity.ProductEntity.Count;
        var newProductCount = productsCount + Entity.Count;

        if (Entity.Id > 0)
        {
            if (Entity.ProductId != previewProductId)
            {

                var previewProduct = await _productsRepository.GetById(previewProductId);
                await _productsRepository.UpdateProductCount(previewProductId, previewProduct!.Count - previewCount);
            }
            else
            {
                newProductCount = productsCount - previewCount + Entity.Count;
            }
        }

        await _productsRepository.UpdateProductCount(Entity.ProductId, newProductCount);

        return true;
    }
}
