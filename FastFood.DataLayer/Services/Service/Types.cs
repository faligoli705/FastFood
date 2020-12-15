using FastFood.DataLayer.Services.Interface;
using FastFood.DomainClass.Domain.Entities;
 using System;
using System.Collections.Generic;
using System.Text;

namespace FastFood.DataLayer.Services.Service
{
    public class Types : IType
    {
        public ServiceResult<Category> AddTtpe(Category type)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<Category> DeleteType(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<Category> GetTypeById(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<IEnumerable<Category>> ListType()
        {
            throw new NotImplementedException();
        }

        public ServiceResult<Category> UpdateType(Category type)
        {
            throw new NotImplementedException();
        }
    }
}
