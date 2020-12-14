using FastFood.DataLayer.Services;
using FastFood.DomainClass.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFood.Services.Interface
{
    public interface IUser
    {
        ServiceResult<UsersEnt> AddTtpe(UsersEnt users);
        ServiceResult<UsersEnt> UpdateUsers(UsersEnt users);
        ServiceResult<UsersEnt> DeleteUsers(int id);
        ServiceResult<UsersEnt> GetUsersById(int id);
        ServiceResult<IEnumerable<UsersEnt>> ListUsers();
    }
}
