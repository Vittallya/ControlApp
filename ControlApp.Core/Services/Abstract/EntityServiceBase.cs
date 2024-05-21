using ControlApp.Core.Entities;
using ControlApp.Core.Interfaces;

namespace ControlApp.Core.Services.Abstract;

internal abstract class EntityServiceBase<TEntity>(IGenericRepository<TEntity> repository) : IEntityService<TEntity>
    where TEntity : IEntity
{
    protected readonly IGenericRepository<TEntity> _repository = repository;

    protected abstract internal Task<EntityOperationResult<TEntity>> ValidateOnAdd(TEntity entity);
    protected abstract internal Task<EntityOperationResult<TEntity>> ValidateOnUpdate(TEntity entity, TEntity preview);
    protected abstract internal Task<EntityOperationResult<TEntity>> ValidateOnDelete(TEntity entity);
    protected abstract internal Task PostProcessOnAdd(TEntity entity);
    protected abstract internal Task PostProcessOnUpdate(TEntity entity, TEntity preview);
    protected abstract internal Task PostProcessOnDelete(TEntity entity);

    public async Task<EntityOperationResult<TEntity>> AddOrUpdateAsync(TEntity entity)
    {
        if(entity.Id > 0)
        {
            var preview = await _repository.FindById(entity.Id);
            var result = await ValidateOnUpdate(entity, preview);
            


            if (result.Status != OperationResultStatus.Error)
            {
                await _repository.UpdateItem(entity);
                await PostProcessOnUpdate(entity, preview);
            }
            return result;
        }

        var resultOnAdd = await ValidateOnAdd(entity);

        if (resultOnAdd.Status != OperationResultStatus.Error)
        {
            entity = await _repository.AddItem(entity);
            await PostProcessOnAdd(entity);
            return new EntityOperationResult<TEntity>(true, entity);
        }

        return resultOnAdd;
    }

    public async Task<EntityOperationResult<TEntity>> DeleteAsync(int id)
    {
        var entity = await _repository.FindById(id);
        var result = await ValidateOnDelete(entity);

        if (result.Status != OperationResultStatus.Error)
        {
            await _repository.DeleteItem(id);
            await PostProcessOnDelete(entity);

        }
        return result;
    }
}
