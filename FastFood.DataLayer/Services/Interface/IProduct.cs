using FastFood.DataLayer.Services;
using FastFood.DomainClass.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFood.DataLayer.Services.Interface
{
    public interface IProduct
    {
        ServiceResult<Products> AddProduct(Products product);
        ServiceResult<Products> UpdateProduct(Products product);
        ServiceResult<Products> DeleteProduct(int id);
        ServiceResult<Products> GetProductById(int id);
        ServiceResult<IEnumerable<Products>> ListProduct();
    }
}
