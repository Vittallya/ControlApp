using ControlApp.Core.Entities;
using ControlApp.Interfaces;
using ControlApp.ViewModels;
using Microsoft.Data.SqlClient;

namespace ControlApp.UserControls;

public partial class ProductReturnDetails : UserControl, IEntityUserControl<ProductReturnEntity>
{
    private readonly IProductsRepository _productsRepository = null!;
    private readonly IGenericRepository<ProductReturnEntity> _productReturns;
    private readonly IGenericRepository<ProductSaleEntity> _salesRepository;

    public ProductReturnDetails()
    {
        InitializeComponent();
    }

    public ProductReturnDetails(IProductsRepository productsRepository, 
        IGenericRepository<ProductReturnEntity> productReturns,
        IGenericRepository<ProductSaleEntity> salesRepository)
        :this()
    {
        this._productsRepository = productsRepository;
        this._productReturns = productReturns;
        _salesRepository = salesRepository;
    }


    public ProductReturnEntity Entity { get; private set; }

    public async void SetupEntity(ProductReturnEntity entity)
    {
        var products = await _productsRepository.GetProducts();
        productsBs.DataSource = products;
        mainBs.DataSource = entity;
        Entity = entity;
        if (entity.Id == 0)
        {
            Entity.Product = products.First();
        }
    }

    public async Task<bool> PostProcess()
    {
        if (string.IsNullOrEmpty(Entity.Reason))
        {
            MessageBox.Show("Должна быть указана причина возврата");
            return false;
        }

        Entity.ProductId = Entity.Product!.Id;
        var sql = "SELECT SUM(Count) AS TotalCount FROM dbo.Sales t WHERE t.ProductId = @id";


        var totalSelled = (await _salesRepository
            .ExecuteSqlRaw<TotalCountViewModel>(sql, new SqlParameter("id", Entity.ProductId)))
            .First()
            .TotalCount;



        sql = "SELECT SUM(Count) AS TotalCount FROM dbo.ProductReturns t WHERE t.ProductId = @id";

        var totalReturned = (await _productReturns
            .ExecuteSqlRaw<TotalCountViewModel>(sql, new SqlParameter("id", Entity.ProductId)))
            .First()
            .TotalCount;

        var sumReturned = Entity.Count + (totalReturned.HasValue ? totalReturned.Value : 0);

        if (totalSelled < sumReturned)
        {
            MessageBox.Show("Количество возвратов по данному товару не может быть больше, чем общее количество продаж");
            return false;
        }

        await _productsRepository.UpdateProductCount(Entity.ProductId, Entity.Count);
        return true;
    }
}
