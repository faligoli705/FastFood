
using FastFood.DataLayer.Services;
using FastFood.DomainClass.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFood.DataLayer.Services.Interface
{ 
    public interface ICategory
    {
        ServiceResult<Category> AddTtpe(Category type);
        ServiceResult<Category> UpdateType(Category type);
        ServiceResult<Category> DeleteType(int id);
        ServiceResult<Category> GetTypeById(int id);
        ServiceResult<IEnumerable<Category>> ListType();
    }
}
