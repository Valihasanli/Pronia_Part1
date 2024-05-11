using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia_HW.DAL;
using Pronia_HW.Models;
using System.Collections.Generic;

namespace Pronia_HW.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {  AppDbContext _context;

        public CategoryController(AppDbContext dbcontext)
        {
           _context = dbcontext;
        }

        [Area("Admin")]
      
        public IActionResult Index()
        {
            List<Category> categories =_context.Categories.Include(x=> x.Products).ToList();
            return View(categories);
        }
        [Area("Admin")]
        public IActionResult Delete(int? id)
        {
            var ctg=_context.Categories.FirstOrDefault(x=>x.Id == id);
            _context.Categories.Remove(ctg);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
