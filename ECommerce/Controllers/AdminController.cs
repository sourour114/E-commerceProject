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
            ViewBag.Message = null;
            if (db.Commercial.Any(x => x.NomPrenom == NomPrenom && x.LogIn == LogIn && x.Password == Password))
                    
            {
                ViewBag.Message = "Déja existant !";
                return View();
                //return Content("<script type='text/javascript'>Swal.fire({icon: 'error',title: 'Oops...',text: 'Something went wrong!'});</script>");
            }
            Commercial commercial = new Commercial();
            commercial.NomPrenom = NomPrenom;
            commercial.Telephone = phone;
            commercial.DateNaissance = DateNaissance;
            commercial.LogIn = LogIn;
            commercial.Password = Password;
            commercial.Salaire = Salaire;
            commercial.Role = Models.Enummeratin.Role.commercial;
            db.Commercial.Add(commercial);
            db.SaveChanges();
            return RedirectToAction("GererComptsCommerciaux", "Admin");
        
        }




        public ActionResult Modifier(int Id)
        {
            Commercial commercial = db.Commercial.Find(Id);

            return View(commercial);
        }
        [HttpPost]
        public ActionResult Modifier(Commercial commercial)
        {
            db.Entry(commercial).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("GererComptsCommerciaux", "Admin");
        }
        public ActionResult Supprimer(int Id)
        {
            db.Commercial.Remove(db.Commercial.Find(Id));
            db.SaveChanges();
            return RedirectToAction("GererComptsCommerciaux", "Admin");
        }

    }
}