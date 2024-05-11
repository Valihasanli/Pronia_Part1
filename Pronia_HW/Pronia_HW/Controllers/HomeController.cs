using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia_HW.DAL;
using Pronia_HW.Models;
using System.Diagnostics;

namespace Pronia_HW.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Product> products =await _context.Products.Include(x=>x.productphotos).Where(x =>x.productphotos.Count>0).ToListAsync();
            return View(products);
        }
        public IActionResult Detail(int? id)
        {
            return View();
        }

    }
}
