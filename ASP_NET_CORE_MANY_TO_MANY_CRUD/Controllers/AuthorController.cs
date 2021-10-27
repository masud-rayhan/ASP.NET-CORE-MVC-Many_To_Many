using ASP_NET_CORE_MANY_TO_MANY_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_CORE_MANY_TO_MANY_CRUD.Controllers
{
    public class AuthorController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AuthorController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task <IActionResult> AuthorList()
        {
            var author = await _db.Authors.ToListAsync();


            return View(author);
        }

        public  IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Author author)
        {
            if (ModelState.IsValid)
            {
                await _db.Authors.AddAsync(author);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(AuthorList));
            }
            return View();
        }




        public async Task<IActionResult> Edit(int? id)
        {
            if(id==null || id <= 0)
            {
                return BadRequest();
            }

            var bookAuthor = await _db.Authors.FindAsync(id);
            //var author1 = await _db.Authors.Where(e => e.AuthorId == (int)id.FirstOrDefault());

            if (bookAuthor == null)
            {
                return NotFound();
            }

            return View(bookAuthor);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Author author)
        {
            if (ModelState.IsValid)
            {
                 _db.Authors.Update(author);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(AuthorList));
            }
            return View(author);
        }

        public async Task<IActionResult> Detele(int? id)
        {
            if(id==null || id <= 0)
            {
                return BadRequest();
            }

            var author = await _db.Authors.FindAsync(id);

            _db.Authors.Remove(author);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(AuthorList));
        }
    }
}
