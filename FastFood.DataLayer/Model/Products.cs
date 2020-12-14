using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastFood.DataLayer.Model
{
    public class Products
    {
        [Key]
        public int IdProducts { get; set; }
        [MaxLength(50)]
        public string NameFood { get; set; }
        public int IdType { get; set; }
        public decimal Price { get; set; }
        public DateTime DateSave { get; set; }
        public DateTime TimeSave { get; set; }
        public DateTime TimeAmadehSazi { get; set; }
        public string PicUrl { get; set; }
        public bool IsDelete { get; set; }
    }
}
