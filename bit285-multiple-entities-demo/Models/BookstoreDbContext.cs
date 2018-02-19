using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IndyBooks.Models
{
    public class BookstoreDbContext : DbContext
    {
     //Constructor - gives the name of the database
        public BookstoreDbContext() : base("IndyBooksDB") { }

     // Entity representing all the books
        public DbSet<Book> Books { get; set; }

      // Entitys representing store members
        public DbSet<Member> Members { get; set; }

     // Virtual Entity representing member purchases
        public virtual ICollection<Book> Purchases { get; set; }

    }
}