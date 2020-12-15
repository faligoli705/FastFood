using FastFood.DataLayer.Services.Interface;
using FastFood.DomainClass.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastFood.DataLayer.Services.Service
{
    public class Factors : IFactory
    {
        public ServiceResult<StoreInvoicing> AddFactory(StoreInvoicing factorys)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<StoreInvoicing> DeleteFactorys(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<StoreInvoicing> GetFactorysById(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<IEnumerable<StoreInvoicing>> ListFactorys()
        {
            throw new NotImplementedException();
        }

        public ServiceResult<StoreInvoicing> UpdateFactorys(StoreInvoicing factorys)
        {
            throw new NotImplementedException();
        }
    }
}
