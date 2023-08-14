using System.Threading.Tasks;
using TestApp.Network;
using TestApp.Network.Products;

namespace TestApp.Data
{
    class ProductManager
    {
        private readonly IProductService _service;

        public ProductManager()
        {
            _service = new ProductService();
        }

        public Task<ProductList> GetProductsAsync()
        {
            return _service.GetProductListAsync();
        }
    }
}
