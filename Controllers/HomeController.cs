using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnettst.Models;

namespace dotnettst.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {            
            return View(_context.Produtos.ToList());
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
