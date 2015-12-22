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
            
            var dane = new HomeModel { 
                ankiety = data.getStazAnkietaStudent(ankietaId).ToArray(),
                ankieta = data.Ankieta.ToArray(),
                ankietaWzor = data.AnkietaWzor.ToArray(),
                pytania = data.AnkietaWzorPytanie.ToArray(),
                odpowiedzi = data.AnkietaWzorOdpowiedz.ToArray()
            };

            return View(dane);
        }

        public bool UpdateAnkieta() {
            int ankietaID = Convert.ToInt32(Request.Form["ankietaID"]);
            string odpowiedzi = Convert.ToString(Request.Form["odpowiedzi"]);

            var update = new HomeModel();

            if (update.updateAnkieta(ankietaID, odpowiedzi))
            {
                return true;
            }
            else {
                return false;
            }

        }
    }
}