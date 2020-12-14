using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastFood.DataLayer.Model
{
    public class Users
    {
        [Key]
        public Int32 IdUser { get; set; }  //معمولا ایدی رو کد ملی میگیرن ولی چون ممکنه کد ملی نباشه یا به هردلیلی نشه اتومات تولید میکنه
        [MaxLength(20)]
        public string FName { get; set; }
        [MaxLength(30)]
        public string LName { get; set; } 
        public Int32 NationalCode { get; set; }
        public Int32 Mobile { get; set; }
        [MaxLength(200)]
        public string AddressUser { get; set; }
        public string PicUrl { get; set; }
        public int StatusAdmin { get; set; }
        public Int32 Pass { get; set; }
        public bool IsDelete { get; set; }

    }
}
