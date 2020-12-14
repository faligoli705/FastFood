using FastFood.DataLayer.DataAccess;
using FastFood.DataLayer.Services.Interface;
using FastFood.DomainClass.Domain.Entities;
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FastFood.DataLayer.Services.Service
{
    public class Products : IProduct
    {
        private readonly FastFoodContext _context;

        public Products(FastFoodContext context)
        {
            this._context = context;
        }
        public ServiceResult<ProductsEnt> AddProduct(ProductsEnt product)
        {
            var errors = new List<string>();
            if (string.IsNullOrEmpty(product.NameFood))
                errors.Add("Name is Null");

            if (_context.Products.Any(a => a.NameFood == product.NameFood))
                errors.Add("Name Food is dupplicate");
           
            if (errors.Any())
                return ServiceResult<ProductsEnt>.Failed(errors);

             
            _context.Products.Add(product);
            var result = _context.SaveChanges();

            if (result > 0)
                return ServiceResult<ProductsEnt>.Succeed(product);
            return ServiceResult<ProductsEnt>.Failed(new List<string> { "Data not inserted!!!" });
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
