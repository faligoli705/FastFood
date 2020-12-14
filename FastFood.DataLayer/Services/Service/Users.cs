using FastFood.DataLayer.Services.Interface;
using FastFood.DomainClass.Domain.Entities;
 using System;
using System.Collections.Generic;
using System.Text;

namespace FastFood.DataLayer.Services.Service
{
    public class Users : IUser
    {
        public ServiceResult<UsersEnt> AddTtpe(UsersEnt users)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<UsersEnt> DeleteUsers(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<UsersEnt> GetUsersById(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<IEnumerable<UsersEnt>> ListUsers()
        {
            throw new NotImplementedException();
        }

        public ServiceResult<UsersEnt> UpdateUsers(UsersEnt users)
        {
            throw new NotImplementedException();
        }
    }
}
