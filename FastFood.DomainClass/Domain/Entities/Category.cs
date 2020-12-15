using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastFood.DomainClass.Domain.Entities
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [MaxLength(50)]
        public string CategoryName { get; set; }
        public DateTime CategoryCreateDate { get; set; }
        public DateTime CategoryCreateTime { get; set; }
        public DateTime CategoryUpdateDate { get; set; }
        public DateTime CategoryUpdateTime { get; set; }
        public DateTime CategoryDeleteDate { get; set; }
        public DateTime CategoryDeleteTime { get; set; }
        public bool IsDelete { get; set; }
    }
}
