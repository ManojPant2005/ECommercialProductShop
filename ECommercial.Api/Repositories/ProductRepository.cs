using ECommercial.Api.Data;
using ECommercial.Api.Entities;
using ECommercial.Api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace ECommercial.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ECommerceDbContext eCommerceDbContext;

        public ProductRepository(ECommerceDbContext eCommerceDbContext)
        {
            this.eCommerceDbContext = eCommerceDbContext;
        }

        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.eCommerceDbContext.ProductCategories.ToListAsync();

            return categories;
        }

        public async Task<ProductCategory> GetCategory(int id)
        {
            var category = await eCommerceDbContext.ProductCategories.SingleOrDefaultAsync(c => c.Id == id);
            return category;
        }

        public async Task<Product> GetItem(int id)
        {
            var product = await eCommerceDbContext.Products
                    .Include(p => p.ProductCategory)
                    .SingleOrDefaultAsync(p => p.Id == id);
            return product;
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.eCommerceDbContext.Products
                                     .Include(p => p.ProductCategory).ToListAsync();

            return products;
        }

        public async Task<IEnumerable<Product>> GetItemsByCategory(int id)
        {
            var products = await this.eCommerceDbContext.Products
                          .Include(p => p.ProductCategory)
                          .Where(p => p.CategoryId == id).ToListAsync();
            return products;
        }
    }
}
