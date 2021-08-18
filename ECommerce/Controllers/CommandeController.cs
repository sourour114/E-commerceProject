using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Controllers
{
    public class CommandeController : Controller
    {
        // GET: Commande
        public ActionResult BonDeCommande()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}