using SimpleCrud.Application.Repositories;
using SimpleCrud.Application.Services;
using SimpleCrud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitofwork)
        {
            this._unitOfWork = unitofwork;
        }

        public async Task CreateProduct(Product Entity)
        {
            await _unitOfWork.Products.AddAsync(Entity);
            await _unitOfWork.CommitAsync();
        }

        public Task UpdateProduct(Product Entity)
        {
            _unitOfWork.Products.Update(Entity);
            _unitOfWork.Commit();

            return Task.CompletedTask;
        }

        public async Task DeleteProduct(int ProductID)
        {
            var product = await _unitOfWork.Products.GetByIdAsync(ProductID);
            _unitOfWork.Products.Remove(product);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _unitOfWork.Products.GetAllAsync();
        }

        public async ValueTask<Product> GetProductByID(int ProductID)
        {
            return await _unitOfWork.Products.GetByIdAsync(ProductID);
        }
    }
}
