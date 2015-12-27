using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace ankiety.Models
{
    public class HomeModel
    {
        public Ankieta[] ankieta { get; set; }
        public AnkietaWzor[] ankietaWzor { get; set; }
        public AnkietaWzorPytanie[] pytania { get; set; }
        public AnkietaWzorOdpowiedz[] odpowiedzi { get; set; }
        public getStazAnkietaStudent_Result[] ankiety { get; set; }
        public StazStudentAnkieta[] ssa { get; set; }
        public int[] json { get; set; }

        public bool updateAnkieta(int id, string json) {
            if (id != null)
            {
                Z707_PZEntities3 data = new Z707_PZEntities3();

                try
                {
                    Ankieta ank = data.Ankieta.Find(id);
                    ank.Odpowiedz = json;
                    ank.StanAnkiety = "1";

                    data.Entry(ank).State = System.Data.Entity.EntityState.Modified;
                    data.SaveChanges();
                    return true;
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    Exception raise = dbEx;
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                                validationErrors.Entry.Entity.ToString(),
                                validationError.ErrorMessage);
                            // raise a new exception nesting
                            // the current instance as InnerException
                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;
                }
            }
            else {
                return false;
            }
        }

        public int[] getAnkietaJson(int AnkietaID) {
            Z707_PZEntities3 data = new Z707_PZEntities3();

            string ankietaJson = data.Ankieta.Find(AnkietaID).Odpowiedz;
            string[] a = ankietaJson.Split(new Char[]{','});

            int[] val = new int[a.Length];
            for (int i = 0; i < a.Length; i++) {
                val[i] = Convert.ToInt32(a[i]);
            }

            return val;
        }
    }
}