using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastFood.DomainClass.Domain.Dto
{
    public class Customers
    {
        public Int32 CustomerId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public Int32 Mobile { get; set; }
        public string Address { get; set; }
        public int StatusCustomer { get; set; } //وضعیت کاربر => 0 غیرفعال شده . 1 فعال . 2 معلق
        public Int32 PasswordCustomer { get; set; }
        public DateTime CustomerCreateDate { get; set; }
        public DateTime CustomerCreateTime { get; set; }
        public DateTime CustomerUpdateDate { get; set; }
        public DateTime CustomerUpdateTime { get; set; }
        public DateTime CustomerDeleteDate { get; set; }
        public DateTime CustomerDeleteTime { get; set; }
        public bool IsDelete { get; set; }

    }
}
