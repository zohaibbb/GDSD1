using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using test11.Models;

namespace test11
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task<bool> AddProductAsync(Product product);
        Task<bool> UpdateProductAsync(Product product);
        Task<bool> RemoveProductAsync(int id);
        Task<IEnumerable<Product>> QueryProductsAsync(Func<Product, bool> predicate);
    }
}
