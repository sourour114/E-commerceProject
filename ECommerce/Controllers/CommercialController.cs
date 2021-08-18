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
            var commercials = db.Commercial.ToList();
            return View(commercials);
        }
    }
}