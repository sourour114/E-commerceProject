using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerce.Models;

namespace ECommerce.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult GetRandom() => View();

        public ActionResult Authentification()
        {
            return View();
        } 
    }
}