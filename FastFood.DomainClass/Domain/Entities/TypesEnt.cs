using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastFood.DomainClass.Domain.Entities
{
    public class TypesEnt
    {
        [Key]
        public virtual int IdType { get; set; }
        [MaxLength(50)]
        public virtual string Name { get; set; }
        public virtual bool IsDelete { get; set; }
    }
}
