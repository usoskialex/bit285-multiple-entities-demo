namespace bit285_multiple_entities_demo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using IndyBooks.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<IndyBooks.Models.BookstoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "IndyBooks.Models.BookstoreDbContext";
        }

        protected override void Seed(IndyBooks.Models.BookstoreDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Books.AddOrUpdate(b => b.BookID,
                new Book()
                {
                    BookID = 1,
                    Title = "Pride and Prejudice",
                    Price = 9.99M,
                    AuthorID = 2
                },
                new Book()
                {
                    BookID = 2,
                    Title = "Northanger Abbey",
                    AuthorID = 2,
                    Price = 12.95M
                },
                new Book()
                {
                    BookID = 3,
                    Title = "David Copperfield",
                    AuthorID = 8,
                    Price = 15.00M
                },
                new Book()
                {
                    BookID = 4,
                    Title = "The Wizard of EarthSea",
                    AuthorID = 9 ,
                    Price = 8.95M
                },
                new Book()
                {
                    BookID = 5,
                    Title = "The Tombs of Atuan",
                    AuthorID = 9,
                    Price = 7.95M
                },
                new Book()
                {
                    BookID = 6,
                    Title = "The Farthest Shore",
                    AuthorID = 9,
                    Price = 9.95M

                });
            //TODO: Add several Author records
            context.Authors.AddOrUpdate(a => a.AuthorID,
                
                new Author()
                {
                    AuthorID = 2,
                    AuthorFN = "Jane",
                    AuthorLN = "Austin",
                    DateOfBirth = 1775

                },
                new Author()
                {
                    AuthorID = 8,
                    AuthorFN = "Charles",
                    AuthorLN = "Dickens",
                    DateOfBirth = 1812

                },
                new Author()
                {
                    AuthorID = 9,
                    AuthorFN = "Ursula",
                    AuthorLN = "Le Guin",
                    DateOfBirth = 1929

                });

            //TODO: Add several Member records
            context.Members.AddOrUpdate(m => m.MemberID,

                new Member
                {
                    MemberID = 2,
                    MemberName = "Alex",
                    PhoneNumber = 2065510447,
                    PaymentType = "cash"

                },
                new Member
                {
                    MemberID = 1,
                    MemberName = "Emilio",
                    PhoneNumber = 2062230447,
                    PaymentType = "visa"

                },
                new Member
                {
                    MemberID = 3,
                    MemberName = "Ian",
                    PhoneNumber = 2064410447,
                    PaymentType = "visa"

                },
                new Member
                {
                    MemberID = 4,
                    MemberName = "Pavel",
                    PhoneNumber = 2065567447,
                    PaymentType = "cash"

                });


            //TODO: Add additional Purchase records
            context.Purchases.AddOrUpdate(p => p.PurchaseID,
                new IndyBooks.Models.Purchase()
                {
                    PurchaseID = 1,
                    Amount = 13.00M,
                    BookID = 6,
                    MemberID = 2
                    //TODO: Add the MemberID value
                },
                new IndyBooks.Models.Purchase()
                {
                    PurchaseID = 2,
                    Amount = 9.00M,
                    BookID = 1,
                    MemberID = 1
                    
                },
                new IndyBooks.Models.Purchase()
                {
                    PurchaseID = 3,
                    Amount = 15.00M,
                    BookID = 3,
                    MemberID = 3
                    
                },
                new IndyBooks.Models.Purchase()
                {
                    PurchaseID = 4,
                    Amount = 11.00M,
                    BookID = 5,
                    MemberID = 1
                   
                });

        }
    }
}
