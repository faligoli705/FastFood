using FastFood.DataLayer.Services.Interface;
using FastFood.DomainClass.Domain.Entities;
 using System;
using System.Collections.Generic;
using System.Text;

namespace FastFood.DataLayer.Services.Service
{
    public class Users : IUser
    {
        public ServiceResult<Customers> AddTtpe(Customers users)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<Customers> DeleteUsers(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<Customers> GetUsersById(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<IEnumerable<Customers>> ListUsers()
        {
            throw new NotImplementedException();
        }

        public ServiceResult<Customers> UpdateUsers(Customers users)
        {
            throw new NotImplementedException();
        }
    }
}
