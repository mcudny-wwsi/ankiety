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
        public ActionResult Index() {
            Z707_PZEntities3 data = new Z707_PZEntities3();

            var links = new HomeModel
            {
                ssa = data.StazStudentAnkieta.ToArray()
            };

            return View(links);
        }

        // GET: Home
        public ActionResult Ankieta(int ankietaId, int stazId, int studentId)
        {
            if (ankietaId > 0 || stazId > 0 || studentId > 0)
            {
                ViewBag.ankietaId = ankietaId;
                ViewBag.stazId = stazId;
                ViewBag.studentId = studentId;

                Z707_PZEntities3 data = new Z707_PZEntities3();

                var dane = new HomeModel
                {
                    ankiety = data.getStazAnkietaStudent(ankietaId).ToArray(),
                    ankieta = data.Ankieta.ToArray(),
                    ankietaWzor = data.AnkietaWzor.ToArray(),
                    pytania = data.AnkietaWzorPytanie.ToArray(),
                    odpowiedzi = data.AnkietaWzorOdpowiedz.ToArray()
                };

                dane.json = dane.getAnkietaJson(ankietaId).ToArray();

                return View(dane);
            }
            else {
                return View("Error");
            }
            
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