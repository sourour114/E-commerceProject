using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerce.DTS;
using ECommerce.Models;

namespace ECommerce.Controllers
{
    public class SharedController : Controller
    {
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(Users user)
        {
            using (AppDbContext context = new AppDbContext())
            {
                if (context.Users.Any(x => x.Name == user.Name && x.LogIn == user.LogIn&& x.Password==user.Role))
                {
                    ViewBag.Message = "Customer already exist.";
                    return View("SignUp", user);
                }
                context.Users.Add(user);
                context.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.Message = "Registration Successful.";
            return RedirectToAction("signin", "Shared");

        }


        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(string Password, string AdrMail)
        {
            using (AppDbContext context = new AppDbContext())
            {
                try
                {
                    Users user = context.Users.FirstOrDefault(x => x.LogIn.ToUpper().Equals(AdrMail.ToUpper()) && x.Password == Password);
                    if (user != null)
                    {
                        if (user.Role == "admin")
                        {
                            return RedirectToAction("Index", "Admin");
                        }
                        else
                        {
                            return RedirectToAction("Index", "Commercial");
                        }
                        
                    }
                    ViewBag.message = "Your login or password is incorrect";
                    return View("SignIn");
                }
                catch (Exception)
                {
                    ViewBag.message = "Your login or password is incorrect";
                    return RedirectToAction("SignIn", "Shared");
                }
            }
        }
    }
}