using FastFood.DomainClass.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFood.DataLayer.Services.Interface
{
    public interface IFactory
    {
        ServiceResult<StoreInvoicing> AddFactory(StoreInvoicing factorys);
        ServiceResult<StoreInvoicing> UpdateFactorys(StoreInvoicing factorys);
        ServiceResult<StoreInvoicing> DeleteFactorys(int id);
        ServiceResult<StoreInvoicing> GetFactorysById(int id);
        ServiceResult<IEnumerable<StoreInvoicing>> ListFactorys();
    }
}
