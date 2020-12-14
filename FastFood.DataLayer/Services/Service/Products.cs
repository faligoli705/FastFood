using FastFood.DomainClass.Domain.Entities;
using FastFood.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastFood.DataLayer.Services.Service
{
    public class Products : IProduct
    {
        public ServiceResult<ProductsEnt> AddTtpe(ProductsEnt product)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<ProductsEnt> DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<ProductsEnt> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<IEnumerable<ProductsEnt>> ListProduct()
        {
            throw new NotImplementedException();
        }

        public ServiceResult<ProductsEnt> UpdateProduct(ProductsEnt product)
        {
            throw new NotImplementedException();
        }
    }
}
