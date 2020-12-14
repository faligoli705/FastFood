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
        ServiceResult<ProductsEnt> AddProduct(ProductsEnt product);
        ServiceResult<ProductsEnt> UpdateProduct(ProductsEnt product);
        ServiceResult<ProductsEnt> DeleteProduct(int id);
        ServiceResult<ProductsEnt> GetProductById(int id);
        ServiceResult<IEnumerable<ProductsEnt>> ListProduct();
    }
}
