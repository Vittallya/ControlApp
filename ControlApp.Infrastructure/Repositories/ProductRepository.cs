using ControlApp.Core.Entities;
using ControlApp.EF;
using ControlApp.Infrastructure.Extensions;
using ControlApp.Infrastructure.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ControlApp.Infrastructure.Repositories;

public class ProductRepository : IProductsRepository
{
    private readonly AppDbContext _dbContext;

    public ProductRepository(AppDbContext dbContext)
    {
        this._dbContext = dbContext;
    }

    public async Task<int> AddProduct(ProductEntity product)
    {
        var model = product.GetModelFromEntityWithoutId();
        await _dbContext.Products.AddAsync(model);
        await _dbContext.SaveChangesAsync();
        return model.Id;
    }

    public async Task<int> UpdateProductCount(int productId, int count)
    {
        var product = await _dbContext.Products.FindAsync(productId);
        product!.Count = count;
        return await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteProduct(int productId)
    {
        var product = await _dbContext.Products.FindAsync(productId);
        _dbContext.Products.Remove(product!);   
        await _dbContext.SaveChangesAsync();
    }

    public async Task<ProductEntity?> GetById(int productId)
    {
        var product = await _dbContext.Products.FindAsync(productId);
        return product?.GetProductEntity();
    }

    public async Task<IReadOnlyCollection<ProductEntity>> GetProducts(int skipCount = -1, int count = -1)
    {
        List<Product> queredFromDb = null!;

        if (skipCount > -1 && count > -1)
        {
            queredFromDb = await _dbContext
                .Products
                .Skip(count)
                .Take(count)
                .ToListAsync();
        }
        else if (count > -1)
        {
            queredFromDb = await _dbContext.Products.Take(count).ToListAsync();
        }

        else if (skipCount > -1)
        {
            queredFromDb = await _dbContext.Products.Skip(skipCount).ToListAsync();
        }
        else
        {
            queredFromDb = await _dbContext.Products.ToListAsync();
        }

        return queredFromDb
            .Select(p => p.GetProductEntity())
            .ToList();
    }

    public async Task<IReadOnlyCollection<ProductEntity>> GetProducts(ProductFilter filter)
    {
        var searchStr = filter.SearchString;

        var queriedProducts = (await _dbContext
            .Products
            .Where(product => product.Name.Contains(searchStr) ||
                              product.Manufacturer.Contains(searchStr) ||
                              product.Category.Contains(searchStr))
            .ToListAsync())
            .Select(p => p.GetProductEntity())
            .ToList();

        return queriedProducts;
    }

    public async Task<int> UpdateProduct(ProductEntity productEntity)
    {
        var product = await _dbContext.Products.FindAsync(productEntity.Id);
        productEntity.CopyDataToModel(product!);
        return await _dbContext.SaveChangesAsync();
    }

    public async Task<int> IncreaceCount(int count, int productId)
    {

        var product = await _dbContext.Products.FindAsync(productId);
        product!.Count += count;
        return await _dbContext.SaveChangesAsync();
    }

    public Task<int> GetCount(int productId)
    {
        var param = new SqlParameter("id", productId);
        var model = _dbContext.Database.SqlQueryRaw<ProductCount>("SELECT Count FROM Products WHERE Id = @id", param);
        return Task.FromResult(model.First().Count);
    }
}
