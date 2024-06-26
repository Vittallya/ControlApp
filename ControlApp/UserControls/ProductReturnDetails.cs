﻿using ControlApp.Core.Entities;
using ControlApp.Core.Interfaces;
using ControlApp.Interfaces;
using ControlApp.ViewModels;
using Microsoft.Data.SqlClient;

namespace ControlApp.UserControls;

public partial class ProductReturnDetails : UserControl, IEntityUserControl<ProductReturnEntity>
{
    private readonly IProductsRepository _productsRepository = null!;
    private readonly IGenericRepository<ProductReturnEntity> _productReturns;
    private readonly IEntityService<ProductReturnEntity> entityService;
    private readonly IGenericRepository<ProductSaleEntity> _salesRepository;

    public ProductReturnDetails()
    {
        InitializeComponent();
    }

    public ProductReturnDetails(IProductsRepository productsRepository, 
        IGenericRepository<ProductReturnEntity> productReturns,
        IEntityService<ProductReturnEntity> entityService,
        IGenericRepository<ProductSaleEntity> salesRepository)
        :this()
    {
        this._productsRepository = productsRepository;
        this._productReturns = productReturns;
        this.entityService = entityService;
        _salesRepository = salesRepository;
    }


    public ProductReturnEntity Entity { get; private set; }
    private int previewProductId;
    private int previewCount;
    public async void SetupEntity(ProductReturnEntity entity)
    {
        var products = await _productsRepository.GetProducts();
        productsBs.DataSource = products;
        mainBs.DataSource = entity;
        Entity = entity;
        previewProductId = entity.ProductId;
        if (entity.Id == 0)
        {
            Entity.Product = products.First();
        }
    }

    public async Task<bool> PostProcess()
    {
        Entity.ProductId = Entity.Product!.Id;

        var result = await entityService.AddOrUpdateAsync(Entity);

        if (result.Status != OperationResultStatus.Ok)
        {
            var image = result.Status == OperationResultStatus.Warning ?
                MessageBoxIcon.Warning : MessageBoxIcon.Error;

            MessageBox.Show(string.Join("\n", result.Errors), "Система", MessageBoxButtons.OK, image);
        }

        return result.Status != OperationResultStatus.Error;
    }

    //public async Task<bool> PostProcess()
    //{
    //    if (string.IsNullOrEmpty(Entity.Reason))
    //    {
    //        MessageBox.Show("Должна быть указана причина возврата");
    //        return false;
    //    }

    //    Entity.ProductId = Entity.Product!.Id;
    //    var sql = "SELECT SUM(Count) AS TotalCount FROM dbo.Sales t WHERE t.ProductId = @id";


    //    var totalSelled = (await _salesRepository
    //        .ExecuteSqlRaw<TotalCountViewModel>(sql, new SqlParameter("id", Entity.ProductId)))
    //        .First()
    //        .TotalCount;



    //    sql = "SELECT SUM(Count) AS TotalCount FROM dbo.ProductReturns t WHERE t.ProductId = @id";

    //    var totalReturned = (await _productReturns
    //        .ExecuteSqlRaw<TotalCountViewModel>(sql, new SqlParameter("id", Entity.ProductId)))
    //        .First()
    //        .TotalCount;

    //    var sumReturned = Entity.Count + (totalReturned.HasValue ? totalReturned.Value : 0);

    //    if (totalSelled < sumReturned)
    //    {
    //        MessageBox.Show("Количество возвратов по данному товару не может быть больше, чем общее количество продаж");
    //        return false;
    //    }

    //    var productsCount = Entity.Product.Count;
    //    var newProductCount = productsCount + Entity.Count;

    //    if (Entity.Id > 0)
    //    {
    //        if(Entity.ProductId != previewProductId)
    //        {

    //            var previewProduct = await _productsRepository.GetById(previewProductId);
    //            await _productsRepository.UpdateProductCount(previewProductId, previewProduct!.Count - previewCount);
    //        }
    //        else
    //        {
    //            newProductCount = productsCount - previewCount + Entity.Count;
    //        }
    //    }

    //    await _productsRepository.UpdateProductCount(Entity.ProductId, newProductCount);
    //    return true;
    //}
}
