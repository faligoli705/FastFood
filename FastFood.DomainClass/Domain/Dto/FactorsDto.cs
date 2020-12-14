using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFood.DomainClass.Domain.Dto
{
    public class FactorsDto
    {
        public virtual Int64 IdFactor { get; set; }
        public virtual int IdUser { get; set; }
        public virtual int IdProdut { get; set; }
        public virtual DateTime DateSave { get; set; }
        public virtual DateTime TimeSave { get; set; }
        public virtual string AddressUser { get; set; }
        public virtual decimal price { get; set; }
        public virtual int QtyFood { get; set; }   //tedad kala 
        public virtual bool Status { get; set; }
    }
}
