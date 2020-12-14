using FastFood.DataLayer.Services.Interface;
using FastFood.DomainClass.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastFood.DataLayer.Services.Service
{
    public class Factors : IFactory
    {
        public ServiceResult<FactorsEnt> AddFactory(FactorsEnt factorys)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<FactorsEnt> DeleteFactorys(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<FactorsEnt> GetFactorysById(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<IEnumerable<FactorsEnt>> ListFactorys()
        {
            throw new NotImplementedException();
        }

        public ServiceResult<FactorsEnt> UpdateFactorys(FactorsEnt factorys)
        {
            throw new NotImplementedException();
        }
    }
}
