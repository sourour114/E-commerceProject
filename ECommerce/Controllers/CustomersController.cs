using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerce.DTS;
using ECommerce.Models;

namespace ECommerce.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        [HttpGet]
        public ActionResult SignIn()
        {
            Customer custumerModel = new Customer();

            return View(custumerModel);
        }
        [HttpPost]
        public ActionResult SignIn(Customer customer)
        {
            using (AppDbContext context = new AppDbContext())
            {
                if(context.Customers.Any(x=> x.Name == customer.Name /*(&& x.AdrMail == customer.AdrMail)*/))
                {
                    ViewBag.Message = "Customer already exist.";
                    return View("SignIn", customer);
                }
                context.Customers.Add(customer);
                context.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.Message = "Registration Successful.";
            return View("SignIn", new Customer());
       
        }

    }
}