using IndyBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndyBooks.ViewModels
{
    public class AddBookViewModel
    {
        public int AuthorID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public IEnumerable<Author> Author { get; set; }

    }
}