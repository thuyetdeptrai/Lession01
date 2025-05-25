using BaiTapLab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapLab3.Controllers
{
    public class ProductController : Controller
    {

        static List<Product> details = new List<Product>()
        {
            new Product() {Id= 1, NameProduct="Bánh Ngọt", Price= 5000},
            new Product() {Id= 2, NameProduct="Bánh Chay", Price= 4000},
            new Product() {Id= 3, NameProduct="Bánh Chua", Price=30000 }
        };
        public IActionResult Details()
        {
            return View(details);
        }
    }
}
