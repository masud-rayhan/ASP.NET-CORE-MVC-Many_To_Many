using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_CORE_MANY_TO_MANY_CRUD.Models
{
    public class Book
    {   
        [Key]
        public int  BookId { get; set; }

        [Required(ErrorMessage ="Please Fill Book Name")]
        public String BookName { get; set; }


        [Required(ErrorMessage ="Please Fill Book Type")]
        [MaxLength(200,ErrorMessage ="Max 200 Char")]
        public string BookType { get; set; }

        public ICollection<Book_Author> Book_Authors { get; set; }
    }
}
