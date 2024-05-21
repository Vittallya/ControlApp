using ControlApp.Core.Entities;
using ControlApp.Core.Services.Abstract;

namespace ControlApp.Core.Services;

internal class ProductIncomeService(IGenericRepository<ProductIncomeEntity> repository, IProductsRepository productsRepository) : EntityServiceBase<ProductIncomeEntity>(repository)
{
    private readonly IProductsRepository _productsRepository = productsRepository;

    protected internal override async Task PostProcessOnAdd(ProductIncomeEntity entity)
    {
        await _productsRepository.IncreaceCount(entity.Count, entity.ProductId);
    }

    protected internal override async Task PostProcessOnDelete(ProductIncomeEntity entity)
    {
        await _productsRepository.IncreaceCount(-entity.Count , entity.ProductId);
    }

    protected internal override async Task PostProcessOnUpdate(ProductIncomeEntity entity, ProductIncomeEntity preview)
    {
        entity.TotalSum = entity.Count * entity.ProductEntity!.Cost;

        if(entity.ProductId != preview.ProductId)
        {
            await PostProcessOnAdd(entity);
            await PostProcessOnDelete(preview);
        }
        else
        {
            await _productsRepository.IncreaceCount(entity.Count - preview.Count, entity.ProductId);
        }
    }

    protected internal override Task<EntityOperationResult<ProductIncomeEntity>> ValidateOnAdd(ProductIncomeEntity entity)
    {
        return Task.FromResult(new EntityOperationResult<ProductIncomeEntity>(true, entity));
    }

    protected internal override async Task<EntityOperationResult<ProductIncomeEntity>> ValidateOnDelete(ProductIncomeEntity entity)
    {
        var productCountCurrent = await _productsRepository.GetCount(entity.ProductId);

        if(productCountCurrent < entity.Count)
        {
            return new EntityOperationResult<ProductIncomeEntity>(false, entity, ["Данная запись не может быть удалена, потому что итоговое количество будет отрицательным"]);
        }

        return new EntityOperationResult<ProductIncomeEntity>(true, entity);
    }

    protected internal override async Task<EntityOperationResult<ProductIncomeEntity>> ValidateOnUpdate(ProductIncomeEntity entity, ProductIncomeEntity previewIncome)
    {

        if (entity.ProductId != previewIncome.ProductId)
        {
            var previewProductCount = await _productsRepository.GetCount(previewIncome.ProductId);

            if(previewProductCount < previewIncome.Count)
            {
                return new EntityOperationResult<ProductIncomeEntity>(false, entity, 
                    ["Невозможно редактирование: количество предыдущего товара не может быть меньше нуля"]);
            }

            return new EntityOperationResult<ProductIncomeEntity>(true, entity);
        }
        else
        {
            var newCount = await _productsRepository.GetCount(entity.ProductId) - previewIncome.Count + entity.Count;

            if (newCount < 0)
            {
                return new EntityOperationResult<ProductIncomeEntity>(false, entity,
                    ["Невозможно редактирование: итоговое количество данного товара не может быть меньше нуля"]);
            }

            return new EntityOperationResult<ProductIncomeEntity>(true, entity);
        }
    }
}
