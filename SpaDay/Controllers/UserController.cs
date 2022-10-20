using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();

            return View(addUserViewModel);
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                if (addUserViewModel.Password == addUserViewModel.VerifyPassword)
                {
                    User newUser = new User
                    {
                        Username = addUserViewModel.UserName,
                        Password = addUserViewModel.Password,
                        Email = addUserViewModel.Email,
                        VerifyPassword = addUserViewModel.VerifyPassword,
                    };
                    return View("Index", newUser);
                }
                else
                {
                    ViewBag.Error = "Passwords do not match. Try again.";
                    return View("Add", addUserViewModel);
                }
            }
            else
            {
                return View("Add", addUserViewModel);
            }
        }          
    }
}



