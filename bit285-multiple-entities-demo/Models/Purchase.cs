using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IndyBooks.Models
{
    public class Purchase
    {
        [Key]
        public int PurchaseID { get; set; }
        public decimal Amount { get; set; }
        public int BookID { get; set; }

        public virtual ICollection<Book> Books { get; set; }

    }
}