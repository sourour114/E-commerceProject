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

        private AppDbContext db = new AppDbContext();





        // GET: Admin
        public ActionResult Index()
        {
            var com = db.Commercial.Count();
            var cmd = db.Commande.Count();
            var clt = db.Client.Count();
            var prod = db.Produit.Count();
            int[] tab = {prod, cmd, clt,com};
            return View(tab);
        }



        //----------------Commercial-------------------------

        public ActionResult GererComptsCommerciaux()
        {
            var commercials = db.Commercial.ToList();
            //var commercials = db.Users.Where(x=>((int)x.Role) == 1).ToList();
            return View(commercials);
        }

       

        [HttpPost]
        public int AjoutCommercial(Commercial commercial)
        {
            if (db.Commercial.Any(x => x.NomPrenom == commercial.NomPrenom && x.LogIn == commercial.LogIn && x.Password == commercial.Password))
                    
            {
                ViewBag.Message = "Déja existant !";
                return 0;
            }
            commercial.Role = Models.Enummeratin.Role.commercial;
            db.Commercial.Add(commercial);
            db.SaveChanges();
            var Id = db.Commercial.Max(x => x.Id);
            return Id;
        
        }

        [HttpPost]
        public Boolean Modifier(Commercial commercial)
        {
            db.Entry(commercial).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return true;
        }


        public ActionResult Supprimer(int Id)
        {
            try
            {
                db.Commercial.Remove(db.Commercial.Find(Id));
                db.SaveChanges();
            }
            catch (Exception)
            {
            }
            return RedirectToAction("GererComptsCommerciaux", "Admin");
        }


        //----------------commande-------------------------

        public ActionResult Commande()
        {
            return View();
        }


        //----------------commande-------------------------
        public ActionResult Client()
        {
            return View();
        }



    }
}