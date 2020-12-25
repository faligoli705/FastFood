using FastFood.DataLayer.Services;
using FastFood.DomainClass.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFood.DataLayer.Services.Interface
{ 
    public interface ICustomer
    {
        ServiceResult<Customers> AddTtype(Customers customers);
        ServiceResult<Customers> UpdateUsers(Customers customers);
        ServiceResult<Customers> DeleteUsers(int id);
        ServiceResult<Customers> GetUsersById(int id);
        ServiceResult<IEnumerable<Customers>> Listcustomers();
    }
}
