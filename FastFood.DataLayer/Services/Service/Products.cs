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
        public ServiceResult<DomainClass.Domain.Entities.Products> AddProduct(DomainClass.Domain.Entities.Products product)
        {
            var errors = new List<string>();
            if (string.IsNullOrEmpty(product.NameFood))
                errors.Add("Name is Null");

            if (_context.Products.Any(a => a.NameFood == product.NameFood))
                errors.Add("Name Food is dupplicate");
           
            if (errors.Any())
                return ServiceResult<DomainClass.Domain.Entities.Products>.Failed(errors);

             
            _context.Products.Add(product);
            var result = _context.SaveChanges();

            if (result > 0)
                return ServiceResult<DomainClass.Domain.Entities.Products>.Succeed(product);
            return ServiceResult<DomainClass.Domain.Entities.Products>.Failed(new List<string> { "Data not inserted!!!" });
        }

        public ServiceResult<DomainClass.Domain.Entities.Products> DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<DomainClass.Domain.Entities.Products> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<IEnumerable<DomainClass.Domain.Entities.Products>> ListProduct()
        {
            throw new NotImplementedException();
        }

        public ServiceResult<DomainClass.Domain.Entities.Products> UpdateProduct(DomainClass.Domain.Entities.Products product)
        {
            throw new NotImplementedException();
        }
    }
}
