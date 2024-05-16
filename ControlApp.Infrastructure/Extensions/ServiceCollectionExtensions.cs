using ControlApp.Core.Entities;
using ControlApp.EF;
using ControlApp.Infrastructure.Models;
using ControlApp.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace ControlApp.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddInfrastructure(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddDbContext<AppDbContext>((sp, options) =>
        {
            var connectionString = sp.GetRequiredService<IConfiguration>()
                .GetConnectionString("Main");

            options.UseSqlServer(connectionString);
        });
        serviceCollection.AddTransient<IUserRepository, UserRepository>();
        serviceCollection.AddTransient<IProductsRepository, ProductRepository>();
        serviceCollection.AddTransient<IGenericRepository<ProductIncomeEntity>, GenericRepository<ProductIncomeEntity, ProductIncome>>();
        serviceCollection.AddTransient<IGenericRepository<ProductReturnEntity>, GenericRepository<ProductReturnEntity, ProductReturn>>();
        serviceCollection.AddTransient<IGenericRepository<ProductSaleEntity>, GenericRepository<ProductSaleEntity, Sale>>();
    }
}
