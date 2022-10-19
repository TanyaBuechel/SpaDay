using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        [Route("/user/")]
        public IActionResult Index()
        {
            return View();
        }

        // GET: /<controller>/add
        [HttpGet]
        [Route("/user/add")]
        public IActionResult Add()
        {
            return View();
        }

        // POST: /<controller>/
        [HttpPost]
        [Route("/user/")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            ViewBag.username = newUser.Username;
            ViewBag.password = newUser.Password;
            if (ViewBag.password == verify)
            {
                return View("Index");
            }
            else
            {
                ViewBag.error = true;
                return Redirect("/user/add");
            }
            
            //if (ViewBag.password != verify)
            //{
            //    ViewBag.error = true;
            //    return Redirect("/user/add");
           // }
           // return View("Index");
        }
        
    }
}
