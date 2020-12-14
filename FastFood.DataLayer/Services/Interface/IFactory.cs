using FastFood.DomainClass.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFood.DataLayer.Services.Interface
{
    public interface IFactory
    {
        ServiceResult<FactorsEnt> AddFactory(FactorsEnt factorys);
        ServiceResult<FactorsEnt> UpdateFactorys(FactorsEnt factorys);
        ServiceResult<FactorsEnt> DeleteFactorys(int id);
        ServiceResult<FactorsEnt> GetFactorysById(int id);
        ServiceResult<IEnumerable<FactorsEnt>> ListFactorys();
    }
}
