using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastFood.DomainClass.Domain.Entities
{
    public class UsersEnt
    {
        [Key]
        public virtual Int32 IdUser { get; set; }  //معمولا ایدی رو کد ملی میگیرن ولی چون ممکنه کد ملی نباشه یا به هردلیلی نشه اتومات تولید میکنه
        [MaxLength(60)]
        public virtual string FName { get; set; }
        [MaxLength(80)]
        public virtual string LName { get; set; }
        public virtual Int32 NationalCode { get; set; }
        public virtual Int32 Mobile { get; set; }
        [MaxLength(300)]
        public virtual string AddressUser { get; set; }
        public virtual string PicUrl { get; set; }
        public virtual int StatusAdmin { get; set; }
        public virtual Int32 Pass { get; set; }
        public virtual bool IsDelete { get; set; }
        
    }
}
