using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerce.DTS;


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
            return View(commercials);
        }
    }
}