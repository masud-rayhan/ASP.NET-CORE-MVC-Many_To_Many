using ASP_NET_CORE_MANY_TO_MANY_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_CORE_MANY_TO_MANY_CRUD.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }




        public async Task <IActionResult> BookList()
        {
            var book = await _db.Books.ToListAsync();

            return View(book);
        }






        public IActionResult Create()
        {
            return View();
        }






        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Create(Book book)
        {
            if (ModelState.IsValid)
            {
                //_db.Books.Add(book);
                await _db.Books.AddAsync(book);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(BookList));
                
            }
            return View(book);
        }






        public async Task<IActionResult> Edit(int? id) /*some Question*/
        {
            if(id== null || id<=0)
            {
                return BadRequest();
            }

            var book = await _db.Books.FindAsync(id);
            //var book1 = await _db.Books.Where(x => x.BookId == (int)id).FirstOrDefault();

            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        
        }






        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }
            _db.Books.Update(book); 
            //_db.Entry(book).State = EntityState.Modified;
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(BookList));
        }







        public async Task<IActionResult> Detele(int? id)
        {
            if(id==null || id <= 0)
            {
                return BadRequest();
            }
            var book = await _db.Books.FindAsync(id);

            //var book =  _db.Books.FirstOrDefaultAsync(e => e.BookId ==id);
            //var book =  _db.Books.Where(x => x.BookId == (int)id).FirstOrDefault();

            _db.Books.Remove(book);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(BookList));

        
        }

    }
}
