using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ankiety.Models
{
    public class HomeModel
    {
        public pytanieByAnkieta_Result[] ssa { get; set; }
        public Ankieta[] ankieta { get; set; }
        public AnkietaWzor[] ankietaWzor { get; set; }
        public AnkietaWzorPytanie[] pytania { get; set; }
        public AnkietaWzorOdpowiedz[] odpowiedzi { get; set; }
        public getStazAnkietaStudent_Result[] ankiety { get; set; }
    }
}