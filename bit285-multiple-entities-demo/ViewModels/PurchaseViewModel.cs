using IndyBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndyBooks.ViewModels
{
    public class PurchaseViewModel
    {
        public int MemberID { get; set; }
        public int BookID { get; set; }
        public decimal Amount { get; set; }

        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Member> Members { get; set; }

}
}