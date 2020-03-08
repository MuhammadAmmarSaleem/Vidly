using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public virtual long  Id { get; set; }
        [StringLength(255)]
        [Required]
        public virtual string  Name { get; set; }
        public virtual bool  IsSubscribedToNewsLetter { get; set; }
        public virtual  MemberShipType  MemberShipType { get; set; }
        public virtual long  MemberShipTypeId { get; set; }

        public virtual DateTime? BirthDate { get; set; }

        [NotMapped]
        public long TotalPurchases { get; set; }
    }
}