<<<<<<< HEAD
using System.Diagnostics;
using BaiTapLab3.Models;
using Microsoft.AspNetCore.Mvc;

=======
﻿using System.Diagnostics;
using BaiTapLab3.Models;
using Microsoft.AspNetCore.Mvc;
>>>>>>> e1d2f840b329d59cb0f7be18a2e9e9669af8599f
namespace BaiTapLab3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
<<<<<<< HEAD

        public IActionResult Index()
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
=======
        public class ProductController : Controller
        {
            public IActionResult Index()
            {
                var products = new List<Product>
            {
                new Product { Id = 1, Name = "Chuột", Price = 100000 },
                new Product { Id = 2, Name = "Bàn phím", Price = 200000 }
            };

                return View(products);
            }
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
>>>>>>> e1d2f840b329d59cb0f7be18a2e9e9669af8599f
}
