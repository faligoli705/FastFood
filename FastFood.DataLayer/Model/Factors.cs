using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastFood.DataLayer.Model
{
    public class Factors
    {
        [Key]
        public  Int64 IdFactor { get; set; }
        public  int IdUser { get; set; }
        public  int IdProdut { get; set; }
        public  DateTime DateSave { get; set; }
        public  DateTime TimeSave { get; set; }
        [MaxLength(300)]
        public  string AddressUser { get; set; }
        public  decimal price { get; set; }
        public  int QtyFood { get; set; }   //tedad kala 
        public  bool Status { get; set; } //وضعیت فاکتور کنسل شده یا حساب شده
 
    }
}
