using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /<controller>/add
        // Render the form
        public IActionResult Add()
        {
            return View();
        }

        // POST: /<controller>/
        [HttpPost]
        [Route("/user/")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            // If the passwords match, return newUser to Index
            if (newUser.Password == verify)
            {
                ViewBag.error = false;
                ViewBag.newUser = newUser;
                return View("Index");
            }
            else
            {
            // If the passwords do not match, send error message, render form again, and return username and email fields.
                ViewBag.error = true;
                ViewBag.userName = newUser.Username;
                ViewBag.email = newUser.Email;
                return View("Add");
            }
        }
        
    }
}
