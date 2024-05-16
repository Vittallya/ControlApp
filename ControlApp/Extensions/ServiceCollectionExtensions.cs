using ControlApp.Abstract;
using ControlApp.Core.Entities;
using ControlApp.Interfaces;
using ControlApp.UserControls;
using Microsoft.Extensions.DependencyInjection;

namespace ControlApp.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddForms(this IServiceCollection services)
    {
        services.AddTransient<EnterForm>();
        services.AddTransient<MainForm>();
        services.AddTransient<ProductsForm>();
        services.AddTransient<DetailForm>();
        services.AddTransient<FormList<ProductIncomeEntity>>();
        services.AddTransient<FormList<ProductReturnEntity>>();
        services.AddTransient<FormList<ProductSaleEntity>>();
    }
    public static void AddUserControls(this IServiceCollection services)
    {
        services.AddTransient<IEntityUserControl<ProductIncomeEntity>, ProductIncomeDetails>();
        services.AddTransient<IEntityListUserControl<ProductIncomeEntity>, ProductsIncomeDataGrid>();

        services.AddTransient<IEntityUserControl<ProductReturnEntity>, ProductReturnDetails>();
        services.AddTransient<IEntityListUserControl<ProductReturnEntity>, ProductReturnList>();

        services.AddTransient<IEntityUserControl<ProductSaleEntity>, SalesDetails>();
        services.AddTransient<IEntityListUserControl<ProductSaleEntity>, SalesList>();
    }
}
