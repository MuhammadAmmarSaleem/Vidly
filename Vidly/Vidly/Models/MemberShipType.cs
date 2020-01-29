using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MemberShipType
    {
        public virtual long  Id { get; set; }
        public virtual int  SignUpFee { get; set; }
        public virtual byte  DurationInMonths { get; set; }
        public virtual byte  DiscountRate { get; set; }
    }
}