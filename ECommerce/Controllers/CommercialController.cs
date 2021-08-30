using ECommerce.DTS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Controllers
{
    public class CommercialController : Controller
    {
        // GET: Commercial
        private AppDbContext db = new AppDbContext();
        public ActionResult Index()
        {
            var cmd = db.Commande.Count();
            var clt = db.Client.Count();
            var prod = db.Produit.Count();
            int[] tab = { prod, cmd, clt};
            return View(tab);
        }
        
    }
}