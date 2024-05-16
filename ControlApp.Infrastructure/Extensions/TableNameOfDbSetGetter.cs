using Microsoft.EntityFrameworkCore;

namespace ControlApp.Infrastructure.Extensions;

public static class TableNameOfDbSetGetter
{
    public static string GetTableName<T>(this DbContext dbContext) where T : class
    {
        var model = dbContext.Model;
        var entityTypes = model.GetEntityTypes();
        var entityType = entityTypes.First(t => t.ClrType == typeof(T));
        var tableNameAnnotation = entityType.GetAnnotation("Relational:TableName");
        var tableName = tableNameAnnotation.Value.ToString();
        return tableName;
    }
}
