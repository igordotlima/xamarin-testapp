using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using TestApp.Data;
using TestApp.Network.Products;

namespace TestApp.Network
{
    class ProductService : BaseRestService, IProductService
    {
        public async Task<ProductList> GetProductListAsync()
        {
            ProductList products = null;

            try
            {
                var response = await GetClient().GetAsync("/products");

                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();

                    products = JsonConvert.DeserializeObject<ProductList>(responseBody);
                }
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Message: {ex.Message}");
                Debug.WriteLine($"Error: {ex.StackTrace}");
            }

            return products;
        }
    }
}
