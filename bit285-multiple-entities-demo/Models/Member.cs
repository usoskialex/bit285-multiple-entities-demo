using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndyBooks.Models
{
    public class Member
    {
        public int MemberID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get { return FirstName + " " + LastName; } }
        // Property to represent the entity relationship: "A Member can have many Purchases"
        public ICollection<Purchase> Purchases { get; set; }
    }
}