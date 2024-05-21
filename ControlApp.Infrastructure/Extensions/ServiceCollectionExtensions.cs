using ControlApp.Core.Entities;
using ControlApp.Core.Interfaces;
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

        serviceCollection.AddTransient<IProductSaleRepository, ProductSaleRepository>();
        serviceCollection.AddTransient<IGenericRepository<ProductIncomeEntity>, ProductIncomeRepository>();

        serviceCollection.AddTransient<IProductIncomeRepository, ProductIncomeRepository>();
        serviceCollection.AddTransient<IGenericRepository<ProductReturnEntity>, ProductReturnRepository>();

        serviceCollection.AddTransient<IProductReturnRepository, ProductReturnRepository>();
        serviceCollection.AddTransient<IGenericRepository<ProductSaleEntity>, ProductSaleRepository>();
    }
}
