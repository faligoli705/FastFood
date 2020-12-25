using FastFood.DataLayer.Services.Interface;
using FastFood.DomainClass.Domain.Entities;
 using System;
using System.Collections.Generic;
using System.Text;

namespace FastFood.DataLayer.Services.Service
{
    public class Customers : ICustomer
    {
        public ServiceResult<DomainClass.Domain.Entities.Customers> AddTtype(DomainClass.Domain.Entities.Customers customers)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<DomainClass.Domain.Entities.Customers> DeleteUsers(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<DomainClass.Domain.Entities.Customers> GetUsersById(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<IEnumerable<DomainClass.Domain.Entities.Customers>> Listcustomers()
        {
            throw new NotImplementedException();
        }

        public ServiceResult<DomainClass.Domain.Entities.Customers> UpdateUsers(DomainClass.Domain.Entities.Customers customers)
        {
            throw new NotImplementedException();
        }
    }
}
