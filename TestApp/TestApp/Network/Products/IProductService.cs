using System.Threading.Tasks;
using TestApp.Data;

namespace TestApp.Network.Products
{
    interface IProductService
    {
        Task<ProductList> GetProductListAsync();
    }
}
