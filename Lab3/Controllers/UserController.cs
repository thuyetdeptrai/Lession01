using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>()
        {
            new User() {id=1,username="aaa",password="1",phone="111",email="111"},
            new User() {id=1,username="aaa",password="1",phone="111",email="111"},
            new User() {id=1,username="aaa",password="1",phone="111",email="111"},
            new User() {id=1,username="aaa",password="1",phone="111",email="111"},
            new User() {id=1,username="aaa",password="1",phone="111",email="111"},
        };
        //Add
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]   
        
        public IActionResult Add(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    users.Add(user);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(user);
        }
//Edit
[HttpGet]
        public ActionResult Edit(int id)
        {
            var user = users.FirstOrDefault(u => u.id == id); 
            if (user == null)
            {
                return NotFound(); 
            }
            return View(user);
        }
        [HttpPost]
        public IActionResult Edit(User user)
        {
            var u = users.FirstOrDefault(x => x.id == user.id);
            if (u != null)
               {
                u.username = user.username;
                u.password = user.password;
                u.phone = user.phone;
                u.email = user.email;
        }
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            return View(users); 
        }

    }
}
