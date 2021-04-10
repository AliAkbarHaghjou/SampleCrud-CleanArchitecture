using AutoMapper;
using SimpleCrud.Domain.Entities;
using SimpleCrud.WebApi.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCrud.WebApi.Mapping
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreatProduct, Product>().ReverseMap();
            CreateMap<UpdateProduct, Product>().ReverseMap();
        }
    }
}
