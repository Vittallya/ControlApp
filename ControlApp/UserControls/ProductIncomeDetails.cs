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
    public async void SetupEntity(ProductIncomeEntity entity)
    {

        _products = await _productsRepository.GetProducts();
        productsBs.DataSource = _products;
        Entity = entity;
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
        await _productsRepository.UpdateProductCount(Entity.ProductId, Entity.Count);
        return true;
    }
}
