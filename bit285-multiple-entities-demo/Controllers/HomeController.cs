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

        /*
         * Purchase Creation and List
         */
        public ActionResult Purchase()
        {
             return View();
        }
        [HttpPost]
        public ActionResult Purchase(Purchase purchase)
        {
            if (ModelState.IsValid)
            {
                db.Purchases.Add(purchase);
                db.SaveChanges();
                return View("Purchases", db.Purchases);
            }
            return View();
        }
        /*
         * Book Creation and List
         * TODO: Update methods and Views to Book create and list Books 
         */
        public ActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBook(Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
            return View("Books", db.Books);
        }

        public ActionResult Books()
        {
            return View("Books", db.Books);
        }
        /*
          * Author Creation and List
          * TODO: Develop methods and Views to create and list Authors 
          */
        public ActionResult AddAuthor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAuthor(Author author)
        {
             if (ModelState.IsValid)
             {
                db.Authors.Add(author);
                db.SaveChanges();
                return View("Authors", db.Authors);
             }
        return View();
        }

        public ActionResult Authors()
        {
            return View("Authors", db.Authors);
        }






        /*
          * Member Creation and List
          * TODO: Develop methods and Views to create and list Members 
          */
        public ActionResult AddMember()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMember(Member member)
        {
            if (ModelState.IsValid)
            {
                db.Members.Add(member);
                db.SaveChanges();
                return View("Members", db.Members);
            }
            return View();
        }

        public ActionResult Members()
        {
            return View("Members", db.Members);
        }


    }
}