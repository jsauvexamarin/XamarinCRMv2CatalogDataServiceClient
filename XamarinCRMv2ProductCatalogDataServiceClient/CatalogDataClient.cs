using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using XamarinCRMv2CatalogDataServiceClient.Models;

namespace XamarinCRMv2CatalogDataServiceClient
{
    public class CatalogDataClient : ICatalogDataClient
    {
        readonly string _ApiServiceUrl;
        readonly string _ApiAppKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="XamarinCRMv2CatalogDataServiceClient.CatalogDataClient"/> class.
        /// </summary>
        /// <param name="serviceUrl">The base service URL of the service.</param>
        /// <param name="apiKey">API key to pass to the service (in HTTP header named X-ZUMO-APPLICATION)</param>
        public CatalogDataClient(string serviceUrl, string apiKey)
        {
            _ApiServiceUrl = serviceUrl;
            _ApiAppKey = apiKey;
        }

        #region IProductsClient implementation

        public async Task<List<Category>> GetCategoriesAsync(string parentCategoryId = null)
        {
            string requestUri = String.Format("Categories/SubCategories?parentCategoryId={0}", parentCategoryId);

            var responseFetcher = new ResponseFetcher<List<Category>>(_ApiServiceUrl, _ApiAppKey);

            return await responseFetcher.GetResponseAsync(requestUri).ConfigureAwait(false);
        }

        public async Task<Category> GetCategoryAsync(string categoryId)
        {
            string requestUri = String.Format("Categories?id={0}", categoryId);

            var responseFetcher = new ResponseFetcher<Category>(_ApiServiceUrl, _ApiAppKey);

            return await responseFetcher.GetResponseAsync(requestUri).ConfigureAwait(false);
        }

        public async Task<List<Product>> GetProductsAsync(string categoryId)
        {
            string requestUri = String.Format("Products/ByCategory?id={0}", categoryId);

            var responseFetcher = new ResponseFetcher<List<Product>>(_ApiServiceUrl, _ApiAppKey);

            return await responseFetcher.GetResponseAsync(requestUri).ConfigureAwait(false);
        }

        public async Task<List<Product>> GetAllChildProductsAsync(string topLevelCategoryId)
        {
            string requestUri = String.Format("Products/ByTopLevelCategory?id={0}", topLevelCategoryId);

            var responseFetcher = new ResponseFetcher<List<Product>>(_ApiServiceUrl, _ApiAppKey);

            return await responseFetcher.GetResponseAsync(requestUri).ConfigureAwait(false);
        }

        public async Task<Product> GetProductByIdAsync(string productId)
        {
            string requestUri = String.Format("Products?id={0}", productId);

            var responseFetcher = new ResponseFetcher<Product>(_ApiServiceUrl, _ApiAppKey);

            return await responseFetcher.GetResponseAsync(requestUri).ConfigureAwait(false);
        }

        public async Task<Product> GetProductByNameAsync(string productName)
        {
            string requestUri = String.Format("Products/ByName?name={0}", productName);

            var responseFetcher = new ResponseFetcher<Product>(_ApiServiceUrl, _ApiAppKey);

            return await responseFetcher.GetResponseAsync(requestUri).ConfigureAwait(false);
        }

        public async Task<List<Product>> SearchAsync(string searchTerm)
        {
            string requestUri = String.Format("Search?q={0}", searchTerm);

            var responseFetcher = new ResponseFetcher<List<Product>>(_ApiServiceUrl, _ApiAppKey);

            return await responseFetcher.GetResponseAsync(requestUri).ConfigureAwait(false);
        }

        #endregion
    }
}

