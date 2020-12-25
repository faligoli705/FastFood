using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastFood.DomainClass.Domain.Entities
{ 
    public class StoreInvoicing
    {
        [Key]
        public Int64 InvoicingId { get; set; }
        public int CustomerId { get; set; }
        public DateTime StoreInvoicingCreateDate { get; set; }
        //public DateTime StoreInvoicingCreateTime { get; set; }
        public DateTime StoreInvoicingUpdateDate { get; set; }
        //public DateTime StoreInvoicingUpdateTime { get; set; }
        public DateTime StoreInvoicingDeleteDate { get; set; }
        //public DateTime StoreInvoicingDeleteTime { get; set; }
        public int StoreInvoicingStatus { get; set; } // وضعیت فاکتور => 0 کنسل شده . 1 پرداخت نشده .2 پرداخت شده
        public bool IsDelete { get; set; }

        public  ICollection<Customers> Customers { get; set; }
    }
}
