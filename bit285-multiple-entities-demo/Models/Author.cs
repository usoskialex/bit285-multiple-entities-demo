using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IndyBooks.Models
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }
        [Display(Name = "First Name")]
        public string AuthorFN { get; set; } //added Author first Name
        [Display(Name = "Last Name")]
        public string AuthorLN { get; set; } //added Author Last Name
        [Display(Name = "Date Of Birth")]
        public int DateOfBirth { get; set; } //published year

        // TODO: Create at least three  appropriate properties

        // TODO: Add Property to represent the entity relationship: "An Author can write many Books"
        public virtual ICollection<Book> BooksList { get; set; }

    }
}