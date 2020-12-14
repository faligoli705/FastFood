using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastFood.DomainClass.Domain.Entities
{ 
    public class FactorsEnt
    {
        [Key]
        public virtual Int64 IdFactor { get; set; }
        public virtual int IdUser { get; set; }
        public virtual int IdProdut { get; set; }
        public virtual DateTime DateSave { get; set; }
        public virtual DateTime TimeSave { get; set; } 
        [MaxLength(300)]
        public virtual string AddressUser { get; set; }
        public virtual decimal price { get; set; }
        public virtual int QtyFood { get; set; }   //tedad kala 
        public virtual bool Status { get; set; }

        public virtual UsersEnt User { get; set; }
        public virtual ProductsEnt Products { get; set; }
    }
}
