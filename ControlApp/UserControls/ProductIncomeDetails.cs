using ControlApp.Core.Entities;
using ControlApp.Core.Interfaces;
using ControlApp.Infrastructure.Models;
using ControlApp.Interfaces;
using DocumentFormat.OpenXml.Vml.Office;

namespace ControlApp.UserControls;

public partial class ProductIncomeDetails : UserControl, IEntityUserControl<ProductIncomeEntity>
{
    private readonly IProductsRepository _productsRepository = null!;
    private readonly IEntityService<ProductIncomeEntity> entityService;
    private IReadOnlyCollection<ProductEntity> _products;
    public ProductIncomeEntity Entity { get; private set; } = null!;

    public ProductIncomeDetails()
    {
        InitializeComponent();
    }

    public ProductIncomeDetails(IProductsRepository productsRepository, IEntityService<ProductIncomeEntity> entityService)
        : this()
    {
        this._productsRepository = productsRepository;
        this.entityService = entityService;
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
        Entity.ProductId = Entity.ProductEntity!.Id;
        Entity.TotalSum = Entity.Count * Entity.ProductEntity!.Cost;
        var result = await entityService.AddOrUpdateAsync(Entity);

        if (result.Status != OperationResultStatus.Ok)
        {
            var image = result.Status == OperationResultStatus.Warning ? 
                MessageBoxIcon.Warning : MessageBoxIcon.Error;

            MessageBox.Show(string.Join("\n", result.Errors), "Система", MessageBoxButtons.OK, image);
        }

        return result.Status != OperationResultStatus.Error;
    }
}
