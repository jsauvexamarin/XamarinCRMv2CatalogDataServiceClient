using System.Threading.Tasks;
using System.Collections.Generic;
using XamarinCRMv2CatalogDataServiceClient.Models;

namespace XamarinCRMv2CatalogDataServiceClient
{
    public interface ICatalogDataClient
    {
        Task<List<Category>> GetCategoriesAsync(string parentCategoryId = null);

        Task<Category> GetCategoryAsync(string categoryId);

        Task<List<Product>> GetProductsAsync(string categoryId);

        Task<List<Product>> GetAllChildProductsAsync(string topLevelCategoryId);

        Task<Product> GetProductByIdAsync(string productId);

        Task<Product> GetProductByNameAsync(string productName);

        Task<List<Product>> SearchAsync(string searchTerm);
    }
}

