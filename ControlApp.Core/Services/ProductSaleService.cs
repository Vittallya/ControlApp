using ControlApp.Core.Entities;
using ControlApp.Core.Interfaces;
using ControlApp.Core.Services.Abstract;

namespace ControlApp.Core.Services;

internal class ProductSaleService(
    IGenericRepository<ProductSaleEntity> repository, 
    IProductsRepository productsRepository
  , IProductIncomeRepository productIncomeRepository
  , IProductSaleRepository productSaleRepository) : EntityServiceBase<ProductSaleEntity>(repository)
{
    private readonly IProductsRepository _productsRepository = productsRepository;
    private readonly IProductIncomeRepository _productIncomeRepository = productIncomeRepository;
    private readonly IProductSaleRepository _productSaleRepository = productSaleRepository;

    protected internal override async Task PostProcessOnAdd(ProductSaleEntity entity)
    {
        await _productsRepository.IncreaceCount(-entity.Count, entity.ProductId);
    }

    protected internal override async Task PostProcessOnDelete(ProductSaleEntity entity)
    {
        await _productsRepository.IncreaceCount(entity.Count, entity.ProductId);
    }

    protected internal override async Task PostProcessOnUpdate(ProductSaleEntity entity, ProductSaleEntity preview)
    {
        if (entity.ProductId != preview.ProductId)
        {
            await PostProcessOnAdd(entity);
            await PostProcessOnDelete(preview);
        }
        else
        {
            await _productsRepository.IncreaceCount(preview.Count - entity.Count, entity.ProductId);
        }
    }

    protected internal override async Task<EntityOperationResult<ProductSaleEntity>> ValidateOnAdd(ProductSaleEntity entity)
    {
        var totalIncomesByProduct = await _productIncomeRepository.GetTotalIncomeCount(entity.ProductId);
        var totalSalesByProduct = await _productSaleRepository.GetTotalSalesCount(entity.ProductId) + entity.Count;

        var count = await _productsRepository.GetCount(entity.ProductId);

        if (entity.Count > count)
        {
            return new EntityOperationResult<ProductSaleEntity>(false, entity, ["Количество продаж превышает количество товара на складе"]);
        }
        if (totalSalesByProduct > totalIncomesByProduct)
        {
            return new EntityOperationResult<ProductSaleEntity>(OperationResultStatus.Warning, entity, ["Количество общее продаж по этому товару превышает общее количество поставок"]);
        }
        return new EntityOperationResult<ProductSaleEntity>(true, entity);

    }

    protected internal override Task<EntityOperationResult<ProductSaleEntity>> ValidateOnDelete(ProductSaleEntity entity)
    {
        return Task.FromResult(new EntityOperationResult<ProductSaleEntity>(true, entity));
    }

    protected internal override Task<EntityOperationResult<ProductSaleEntity>> ValidateOnUpdate(ProductSaleEntity entity, ProductSaleEntity preview)
    {
        return Task.FromResult(new EntityOperationResult<ProductSaleEntity>(true, entity));
    }
}
