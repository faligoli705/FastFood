using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastFood.DomainClass.Domain.Entities
{
    public class ProductsEnt
    {
        [Key]
        public virtual int IdProducts { get; set; } 
        [MaxLength(80)]
        public virtual string NameFood { get; set; }
        public virtual int IdType { get; set; }
        public virtual decimal Price { get; set; }
        public virtual DateTime DateSave { get; set; }
        public virtual DateTime TimeSave { get; set; }
        public virtual DateTime TimeAmadehSazi { get; set; }
        public virtual string PicUrl { get; set; }
        public virtual bool IsDelete { get; set; }
        public virtual TypesEnt Types { get; set; }
    }
}
