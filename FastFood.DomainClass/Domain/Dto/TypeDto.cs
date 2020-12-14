using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFood.DomainClass.Domain.Dto
{
    public class TypeDto
    {
        public virtual int IdType { get; set; }
        public virtual string Name { get; set; }
        public virtual bool IsDelete { get; set; }
    }
}
