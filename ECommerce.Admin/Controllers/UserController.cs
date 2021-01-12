using ECommerce.Admin.Filters;
using ECommerce.Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Admin.Controllers
{
   
    public class UserController : Controller
    {
        UserLoginViewModel tempUser = new UserLoginViewModel() {  Email = "admin@ecommerce.com", Password = "123456" };
      

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserLoginViewModel user)
        {
            if (user.Email == tempUser.Email && user.Password == tempUser.Password)
            {
                //Sessiona giriş yapan kullanıcının id'sini kayıt eder.
                HttpContext.Session.SetString("Login", (user.Email).ToString());
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

       
    }
}
