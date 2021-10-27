using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_CORE_MANY_TO_MANY_CRUD.Models
{
    public class Book_Author
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Book")]
        public int  BookId { get; set; }
        public Book Book { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
