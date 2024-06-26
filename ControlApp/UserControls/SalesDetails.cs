﻿using ControlApp.Core.Entities;
using ControlApp.Core.Interfaces;
using ControlApp.Interfaces;


namespace ControlApp.UserControls;

public partial class SalesDetails : UserControl, IEntityUserControl<ProductSaleEntity>
{
    private readonly IProductsRepository _productsRepository;
    private readonly IEntityService<ProductSaleEntity> entityService;

    public SalesDetails()
    {
        InitializeComponent();
    }

    public SalesDetails(IProductsRepository productsRepository, IEntityService<ProductSaleEntity> entityService)
        :this()
    {
        this._productsRepository = productsRepository;
        this.entityService = entityService;
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
        Entity.ProductId = Entity.Product!.Id;
        Entity.TotalSum = Entity.Count * Entity.Product!.Cost;


        var result = await entityService.AddOrUpdateAsync(Entity);

        if (result.Status != OperationResultStatus.Ok)
        {
            var image = result.Status == OperationResultStatus.Warning ?
                MessageBoxIcon.Warning : MessageBoxIcon.Error;

            MessageBox.Show(string.Join("\n", result.Errors), "Система", MessageBoxButtons.OK, image);
        }

        return result.Status != OperationResultStatus.Error;

        //if(Entity.Count > Entity.Product!.Count)
        //{
        //    MessageBox.Show("Указанное количество проданного товара больше, чем по факту имеется");
        //    return false;
        //}

        //Entity.TotalSum = Entity.Product!.Cost * Entity.Count;
        //Entity.ProductId = Entity.Product!.Id;

        //var productsCount = Entity.Product.Count;
        //var newProductCount = productsCount - Entity.Count;

        //if (Entity.Id > 0)
        //{
        //    if(Entity.ProductId != previewProductId)
        //    {
        //        var previewProduct = await _productsRepository.GetById(previewProductId);
        //        await _productsRepository.UpdateProductCount(previewProductId, previewProduct!.Count + previewSelled);
        //    }
        //    else
        //    {
        //        newProductCount = Entity.Count + previewSelled - Entity.Count;
        //    }

        //}
        //await _productsRepository.UpdateProductCount(Entity.ProductId, newProductCount);
        //return true;
    }
}
