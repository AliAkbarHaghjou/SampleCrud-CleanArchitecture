using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleCrud.Application.Services;
using SimpleCrud.Domain.Entities;
using SimpleCrud.WebApi.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCrud.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;
        private IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var productList = await _productService.GetAllProducts();
            return Ok(productList);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var productList = await _productService.GetProductByID(id);
            return Ok(productList);
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreatProduct model)
        {
            var product = _mapper.Map<Product>(model);
            await _productService.CreateProduct(product);
            return Ok();
        }
        [HttpPut]
        public IActionResult Put(UpdateProduct model)
        {
            var product = _mapper.Map<Product>(model);
            _productService.UpdateProduct(product);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _productService.DeleteProduct(id);
            return Ok();
        }
    }
}
