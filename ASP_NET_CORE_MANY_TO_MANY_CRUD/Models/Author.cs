using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_CORE_MANY_TO_MANY_CRUD.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required(ErrorMessage ="Please Fill Author Name")]
        public string AuthorName { get; set; }
        
        [Required(ErrorMessage ="Please Fill Mail")]
        public string Mail { get; set; }


        public ICollection<Book_Author> book_Authors { get; set; }
    }
}
