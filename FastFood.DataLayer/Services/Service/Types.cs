using FastFood.DomainClass.Domain.Entities;
using FastFood.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastFood.DataLayer.Services.Service
{
    public class Types : IType
    {
        public ServiceResult<TypesEnt> AddTtpe(TypesEnt type)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<TypesEnt> DeleteType(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<TypesEnt> GetTypeById(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<IEnumerable<TypesEnt>> ListType()
        {
            throw new NotImplementedException();
        }

        public ServiceResult<TypesEnt> UpdateType(TypesEnt type)
        {
            throw new NotImplementedException();
        }
    }
}
