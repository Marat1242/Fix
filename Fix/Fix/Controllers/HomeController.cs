using Fix.Models;
using Fix.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Fix.Controllers
{
    public class HomeController : Controller
    {
        EFDbContext db;
        public HomeController(EFDbContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Items.ToListAsync());
        }
      
       


       

        public IActionResult Explore()
        {
            return View();
        }
        public IActionResult Author()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
       


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}