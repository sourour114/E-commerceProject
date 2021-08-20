using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerce.DTS;
using ECommerce.Models;


namespace ECommerce.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }



        private AppDbContext db = new AppDbContext();


        public ActionResult GererComptsCommerciaux()
        {
            var commercials = db.Commercial.ToList();
            //var commercials = db.Users.Where(x=>((int)x.Role) == 1).ToList();
            return View(commercials);
        }



        public ActionResult AjoutCommercial()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AjoutCommercial(string NomPrenom, int phone, string DateNaissance, string LogIn, string Password, int Salaire)
        //public ActionResult AjoutCommercial(Commercial commercial)
        {
            if (db.Commercial.Any(x => x.NomPrenom == NomPrenom && x.LogIn == LogIn && x.Password == Password))
            {
                ViewBag.Message = "Déja existant !";
                //return View();
                //return Content("<script language='javascript' type='text/javascript'>alert('Thanks for Feedback!');</script>");
            }
            Commercial commercial = new Commercial();
            commercial.NomPrenom = NomPrenom;
            commercial.Telephone = phone;
            commercial.DateNaissance = DateNaissance;
            commercial.LogIn = LogIn;
            commercial.Password = Password;
            commercial.Salaire = Salaire;
            db.Commercial.Add(commercial);
            db.SaveChanges(); 
            return RedirectToAction("GererComptsCommerciaux", "Admin");
        }

    }
}