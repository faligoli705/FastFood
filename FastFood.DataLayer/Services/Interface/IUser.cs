using FastFood.DataLayer.Services;
using FastFood.DomainClass.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFood.DataLayer.Services.Interface
{ 
    public interface IUser
    {
        ServiceResult<Customers> AddTtpe(Customers users);
        ServiceResult<Customers> UpdateUsers(Customers users);
        ServiceResult<Customers> DeleteUsers(int id);
        ServiceResult<Customers> GetUsersById(int id);
        ServiceResult<IEnumerable<Customers>> ListUsers();
    }
}
