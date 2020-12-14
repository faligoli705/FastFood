
using FastFood.DataLayer.Services;
using FastFood.DomainClass.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFood.DataLayer.Services.Interface
    public interface IType
    {
        ServiceResult<TypesEnt> AddTtpe(TypesEnt type);
        ServiceResult<TypesEnt> UpdateType(TypesEnt type);
        ServiceResult<TypesEnt> DeleteType(int id);
        ServiceResult<TypesEnt> GetTypeById(int id);
        ServiceResult<IEnumerable<TypesEnt>> ListType();
    }
}
