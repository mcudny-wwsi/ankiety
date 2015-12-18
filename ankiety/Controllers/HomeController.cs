using ankiety.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ankiety.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Ankieta(int ankietaId, int stazId, int studentId)
        {
            ViewBag.ankietaId = ankietaId;
            ViewBag.stazId = stazId;
            ViewBag.studentId = studentId;

            Z707_PZEntities3 data = new Z707_PZEntities3();
            
            var dane = new HomeModel { ssa = data.pytanieByAnkieta(ankietaId).ToArray() };

            return View(dane);
        }
    }
}