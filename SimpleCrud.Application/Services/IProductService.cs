using SimpleCrud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Application.Services
{
    public interface IProductService
    {

        Task CreateProduct(Product Entity);
        Task UpdateProduct(Product Entity);
        Task DeleteProduct(int ProductID);
        Task<IEnumerable<Product>> GetAllProducts();
        ValueTask<Product> GetProductByID(int ProductID);
    }
}
