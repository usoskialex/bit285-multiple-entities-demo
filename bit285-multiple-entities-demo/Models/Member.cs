using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IndyBooks.Models
{
    public class Member
    {
        [Key]
        public int MemberID { get; set; }

        // TODO: Create at least three  appropriate properties
        [Display(Name = "Member Name")]
        public string MemberName { get; set; }
        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }
        [Display(Name = "Payment Type")]
        public string PaymentType { get; set; }

        // TODO: Add Property to represent the entity relationship: "A Member can have many Purchases"

        public virtual ICollection<Purchase> MemberHistory { get; set; }

    }
}