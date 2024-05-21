using ControlApp.Core.Entities;
using ControlApp.Core.Interfaces;
using ControlApp.Core.Services.Abstract;

namespace ControlApp.Core.Services;

internal class ProductReturnService(IGenericRepository<ProductReturnEntity> repository
    , IProductSaleRepository productSaleRepository
    , IProductReturnRepository productReturnRepository
    , IProductsRepository productsRepository) : EntityServiceBase<ProductReturnEntity>(repository)
{
    private readonly IProductSaleRepository _productSaleRepository = productSaleRepository;
    private readonly IProductReturnRepository _productReturnRepository = productReturnRepository;
    private readonly IProductsRepository _productsRepository = productsRepository;

    protected internal override async Task PostProcessOnAdd(ProductReturnEntity entity)
    {
        await _productsRepository.IncreaceCount(entity.Count, entity.ProductId);
    }

    protected internal override async Task PostProcessOnDelete(ProductReturnEntity entity)
    {
        await _productsRepository.IncreaceCount(-entity.Count, entity.ProductId);
    }

    protected internal override async Task PostProcessOnUpdate(ProductReturnEntity entity, ProductReturnEntity preview)
    {
        if (entity.ProductId != preview.ProductId)
        {
            await PostProcessOnDelete(preview);
            await PostProcessOnAdd(entity);
        }
        else if(entity.Count !=  preview.Count)
        {
            await _productsRepository.IncreaceCount(entity.Count - preview.Count, entity.ProductId);
        }
    }

    protected internal override async Task<EntityOperationResult<ProductReturnEntity>> ValidateOnAdd(ProductReturnEntity entity)
    {
        var errosList = new List<string>();

        if (string.IsNullOrEmpty(entity.Reason))
        {
            errosList.Add("Должна быть указана причина возврата");
        }

        var totalSales = await _productSaleRepository.GetTotalSalesCount(entity.ProductId);
        var totalReturns = await _productReturnRepository.GetTotalCount(entity.ProductId) + entity.Count;

        if(totalReturns > totalSales)
        {
            errosList.Add("Общее количество возвратов по данному товару не может быть больше, чем общее количество продаж");
        }

        return new EntityOperationResult<ProductReturnEntity>(errosList.Count == 0, entity, errosList);
    }

    protected internal override Task<EntityOperationResult<ProductReturnEntity>> ValidateOnDelete(ProductReturnEntity entity)
    {
        return Task.FromResult(new EntityOperationResult<ProductReturnEntity>(true, entity));
    }

    protected internal override async Task<EntityOperationResult<ProductReturnEntity>> ValidateOnUpdate(ProductReturnEntity entity, ProductReturnEntity preview)
    {
        if(entity.ProductId != preview.ProductId)
        {
            var validateOnAdd = await ValidateOnAdd(entity);
            var validateOnDelete = await ValidateOnDelete(preview);

            var isError = validateOnAdd.Status == OperationResultStatus.Error || validateOnDelete.Status == OperationResultStatus.Error;

            return new EntityOperationResult<ProductReturnEntity>(isError, entity, validateOnAdd.Errors.Union(validateOnDelete.Errors).ToList());
        }
        else if(entity.Count != preview.Count)
        {
            var totalSales = await _productSaleRepository.GetTotalSalesCount(entity.ProductId);
            var totalReturns = await _productReturnRepository.GetTotalCount(entity.ProductId) + entity.Count - preview.Count;

            if (totalReturns > totalSales)
            {
                return new EntityOperationResult<ProductReturnEntity>(false, entity, 
                    ["Общее количество возвратов по данному товару не может быть больше, чем общее количество продаж"]);
            }
        }

        return new EntityOperationResult<ProductReturnEntity>(true, entity);
    }
}
