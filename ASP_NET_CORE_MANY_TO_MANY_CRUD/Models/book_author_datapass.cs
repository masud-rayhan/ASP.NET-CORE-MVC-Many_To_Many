using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_CORE_MANY_TO_MANY_CRUD.Models
{
    public class book_author_datapass
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string BookType { get; set; }
        public string AuthorName { get; set; }
        public string AuthorMail { get; set; }
    }
}
