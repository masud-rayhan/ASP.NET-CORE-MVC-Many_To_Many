using ASP_NET_CORE_MANY_TO_MANY_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_CORE_MANY_TO_MANY_CRUD.Controllers
{
    public class Book_AuthorController : Controller
    {
        private readonly ApplicationDbContext _db;

        public Book_AuthorController(ApplicationDbContext db) 
        {
            _db = db;
        }

        public IActionResult Book_AuthorList()
        {
            try
            {
                //var book_author = from b in _db.Books
                //                      join ba in _db.Book_Authors on b.BookId equals ba.BookId
                //                      join a in _db.Authors on ba.AuthorId equals a.AuthorId

                //                      select new book_author_datapass
                //                      {
                //                          Id = ba.Id,
                //                          BookName = ba.Book.BookName,
                //                          BookType = ba.Book.BookType,
                //                          AuthorName = ba.Author.AuthorName,
                //                          AuthorMail = ba.Author.Mail
                //                      };

                var book_author = _db.Book_Authors
                    .Include(b => b.Book)
                    .Include(a => a.Author);





                return View(book_author);

            }catch(Exception ex)
            {
                return View(ex);
            }
            
        }

        public IActionResult Create()
        {
            BookLoad();
            AuthorLoad();
            return View();
        }



        public void BookLoad()
        {
            try
            {
                List<Book> bookList = new List<Book>();
                bookList = _db.Books.ToList();
                bookList.Insert(0, new Book {BookId=0,BookName="Please Select",BookType="" });
                ViewBag.BookList = bookList;

            }
            catch(Exception ex)
            {

            }
        }

        public void AuthorLoad()
        {
            try
            {
                List<Author> authorList = new List<Author>();
                authorList = _db.Authors.ToList();
                authorList.Insert(0, new Author { AuthorId = 0, AuthorName = "Please Select", Mail = "" });
                ViewBag.AuthorList = authorList;

            }
            catch (Exception ex)
            {

            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Book_Author book_Author)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _db.Book_Authors.AddAsync(book_Author);
                    await _db.SaveChangesAsync();
                }

                return RedirectToAction(nameof(Book_AuthorList));

            }catch(Exception ex)
            {
                return RedirectToAction(nameof(Book_AuthorList));
            }
        }

        



       

    }


}
