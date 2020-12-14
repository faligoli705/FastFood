using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastFood.DataLayer.Model
{
    public class Types
    {
        [Key]
        public int IdType { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public bool IsDelete { get; set; }
    }
}
