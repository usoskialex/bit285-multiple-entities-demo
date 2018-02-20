using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IndyBooks.Models;

namespace IndyBooks.Controllers
{
    public class HomeController : Controller
    {
        BookstoreDbContext db = new BookstoreDbContext();

        public ActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBook(Book newBook)
        {
             return View(db.Books);
        }

        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(Book searchBook)
        {
            var foundBooks = db.Books.Where(b => b.Author == searchBook.Author);

            return View("SearchResult", foundBooks);
        }

        public ActionResult Purchase()
        {
            Purchase p = new Purchase();
            p.Books = db.Books.ToList();

            return View(p);
        }
        [HttpPost]
        public ActionResult Purchase(Purchase purchase)
        {
            if(ModelState.IsValid)
            {
                db.Purchases.Add(purchase);
                db.SaveChanges();
                return View("Purchased", db.Purchases);
            }
            
            return View();
        }

    }
}