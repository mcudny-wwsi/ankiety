﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ankiety.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Z707_PZEntities3 : DbContext
    {
        public Z707_PZEntities3()
            : base("name=Z707_PZEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adres> Adres { get; set; }
        public virtual DbSet<AdresKraj> AdresKraj { get; set; }
        public virtual DbSet<AdresTyp> AdresTyp { get; set; }
        public virtual DbSet<AnkietaWzor> AnkietaWzor { get; set; }
        public virtual DbSet<AnkietaWzorOdpowiedz> AnkietaWzorOdpowiedz { get; set; }
        public virtual DbSet<AnkietaWzorPytanie> AnkietaWzorPytanie { get; set; }
        public virtual DbSet<Kierunek> Kierunek { get; set; }
        public virtual DbSet<Pracodawca> Pracodawca { get; set; }
        public virtual DbSet<Staz> Staz { get; set; }
        public virtual DbSet<StazPraktykaTyp> StazPraktykaTyp { get; set; }
        public virtual DbSet<StazStudentAnkieta> StazStudentAnkieta { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Umowa> Umowa { get; set; }
        public virtual DbSet<UmowaWzor> UmowaWzor { get; set; }
        public virtual DbSet<UmowaWzorZmienne> UmowaWzorZmienne { get; set; }
        public virtual DbSet<UmowaZmienne> UmowaZmienne { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Ankieta> Ankieta { get; set; }
    
        [DbFunction("Z707_PZEntities3", "pytanieByAnkieta")]
        public virtual IQueryable<pytanieByAnkieta_Result> pytanieByAnkieta(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<pytanieByAnkieta_Result>("[Z707_PZEntities3].[pytanieByAnkieta](@ID)", iDParameter);
        }
    
        public virtual int AdresDodaj(Nullable<int> adresTyp_ID, Nullable<int> adresKraj_ID, string adresMiasto, string adresKod, string adresUlicaTyp, string adresUlica, string adresUlicaNR, string adresWojewodztwo)
        {
            var adresTyp_IDParameter = adresTyp_ID.HasValue ?
                new ObjectParameter("AdresTyp_ID", adresTyp_ID) :
                new ObjectParameter("AdresTyp_ID", typeof(int));
    
            var adresKraj_IDParameter = adresKraj_ID.HasValue ?
                new ObjectParameter("AdresKraj_ID", adresKraj_ID) :
                new ObjectParameter("AdresKraj_ID", typeof(int));
    
            var adresMiastoParameter = adresMiasto != null ?
                new ObjectParameter("AdresMiasto", adresMiasto) :
                new ObjectParameter("AdresMiasto", typeof(string));
    
            var adresKodParameter = adresKod != null ?
                new ObjectParameter("AdresKod", adresKod) :
                new ObjectParameter("AdresKod", typeof(string));
    
            var adresUlicaTypParameter = adresUlicaTyp != null ?
                new ObjectParameter("AdresUlicaTyp", adresUlicaTyp) :
                new ObjectParameter("AdresUlicaTyp", typeof(string));
    
            var adresUlicaParameter = adresUlica != null ?
                new ObjectParameter("AdresUlica", adresUlica) :
                new ObjectParameter("AdresUlica", typeof(string));
    
            var adresUlicaNRParameter = adresUlicaNR != null ?
                new ObjectParameter("AdresUlicaNR", adresUlicaNR) :
                new ObjectParameter("AdresUlicaNR", typeof(string));
    
            var adresWojewodztwoParameter = adresWojewodztwo != null ?
                new ObjectParameter("AdresWojewodztwo", adresWojewodztwo) :
                new ObjectParameter("AdresWojewodztwo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AdresDodaj", adresTyp_IDParameter, adresKraj_IDParameter, adresMiastoParameter, adresKodParameter, adresUlicaTypParameter, adresUlicaParameter, adresUlicaNRParameter, adresWojewodztwoParameter);
        }
    
        public virtual int AdresKrajDodaj(string adresKraj, string adresKraj_Info)
        {
            var adresKrajParameter = adresKraj != null ?
                new ObjectParameter("AdresKraj", adresKraj) :
                new ObjectParameter("AdresKraj", typeof(string));
    
            var adresKraj_InfoParameter = adresKraj_Info != null ?
                new ObjectParameter("AdresKraj_Info", adresKraj_Info) :
                new ObjectParameter("AdresKraj_Info", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AdresKrajDodaj", adresKrajParameter, adresKraj_InfoParameter);
        }
    
        public virtual int AdresTypDodaj(string adresTyp, string adresTyp_Info)
        {
            var adresTypParameter = adresTyp != null ?
                new ObjectParameter("AdresTyp", adresTyp) :
                new ObjectParameter("AdresTyp", typeof(string));
    
            var adresTyp_InfoParameter = adresTyp_Info != null ?
                new ObjectParameter("AdresTyp_Info", adresTyp_Info) :
                new ObjectParameter("AdresTyp_Info", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AdresTypDodaj", adresTypParameter, adresTyp_InfoParameter);
        }
    
        public virtual int AnkietaDodaj(Nullable<int> ankietaWzor_ID, Nullable<int> pytanie_LP, Nullable<int> odp_LP, string stanAnkiety, string odpowiedz)
        {
            var ankietaWzor_IDParameter = ankietaWzor_ID.HasValue ?
                new ObjectParameter("AnkietaWzor_ID", ankietaWzor_ID) :
                new ObjectParameter("AnkietaWzor_ID", typeof(int));
    
            var pytanie_LPParameter = pytanie_LP.HasValue ?
                new ObjectParameter("Pytanie_LP", pytanie_LP) :
                new ObjectParameter("Pytanie_LP", typeof(int));
    
            var odp_LPParameter = odp_LP.HasValue ?
                new ObjectParameter("Odp_LP", odp_LP) :
                new ObjectParameter("Odp_LP", typeof(int));
    
            var stanAnkietyParameter = stanAnkiety != null ?
                new ObjectParameter("StanAnkiety", stanAnkiety) :
                new ObjectParameter("StanAnkiety", typeof(string));
    
            var odpowiedzParameter = odpowiedz != null ?
                new ObjectParameter("Odpowiedz", odpowiedz) :
                new ObjectParameter("Odpowiedz", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AnkietaDodaj", ankietaWzor_IDParameter, pytanie_LPParameter, odp_LPParameter, stanAnkietyParameter, odpowiedzParameter);
        }
    
        public virtual int AnkietaWzorDodaj(string nazwaAnkiety, string wersja, Nullable<bool> aktywna)
        {
            var nazwaAnkietyParameter = nazwaAnkiety != null ?
                new ObjectParameter("NazwaAnkiety", nazwaAnkiety) :
                new ObjectParameter("NazwaAnkiety", typeof(string));
    
            var wersjaParameter = wersja != null ?
                new ObjectParameter("Wersja", wersja) :
                new ObjectParameter("Wersja", typeof(string));
    
            var aktywnaParameter = aktywna.HasValue ?
                new ObjectParameter("Aktywna", aktywna) :
                new ObjectParameter("Aktywna", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AnkietaWzorDodaj", nazwaAnkietyParameter, wersjaParameter, aktywnaParameter);
        }
    
        public virtual int AnkietaWzorOdpowiedzDodaj(Nullable<int> ankietaWzorPytanie_ID, Nullable<int> odpowiedz_LP, string odpowiedz)
        {
            var ankietaWzorPytanie_IDParameter = ankietaWzorPytanie_ID.HasValue ?
                new ObjectParameter("AnkietaWzorPytanie_ID", ankietaWzorPytanie_ID) :
                new ObjectParameter("AnkietaWzorPytanie_ID", typeof(int));
    
            var odpowiedz_LPParameter = odpowiedz_LP.HasValue ?
                new ObjectParameter("Odpowiedz_LP", odpowiedz_LP) :
                new ObjectParameter("Odpowiedz_LP", typeof(int));
    
            var odpowiedzParameter = odpowiedz != null ?
                new ObjectParameter("Odpowiedz", odpowiedz) :
                new ObjectParameter("Odpowiedz", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AnkietaWzorOdpowiedzDodaj", ankietaWzorPytanie_IDParameter, odpowiedz_LPParameter, odpowiedzParameter);
        }
    
        public virtual int AnkietaWzorPytanieDodaj(Nullable<int> ankietaWzor_ID, Nullable<int> pytanie_LP, string pytanie, Nullable<int> odpowiedzTyp)
        {
            var ankietaWzor_IDParameter = ankietaWzor_ID.HasValue ?
                new ObjectParameter("AnkietaWzor_ID", ankietaWzor_ID) :
                new ObjectParameter("AnkietaWzor_ID", typeof(int));
    
            var pytanie_LPParameter = pytanie_LP.HasValue ?
                new ObjectParameter("Pytanie_LP", pytanie_LP) :
                new ObjectParameter("Pytanie_LP", typeof(int));
    
            var pytanieParameter = pytanie != null ?
                new ObjectParameter("Pytanie", pytanie) :
                new ObjectParameter("Pytanie", typeof(string));
    
            var odpowiedzTypParameter = odpowiedzTyp.HasValue ?
                new ObjectParameter("OdpowiedzTyp", odpowiedzTyp) :
                new ObjectParameter("OdpowiedzTyp", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AnkietaWzorPytanieDodaj", ankietaWzor_IDParameter, pytanie_LPParameter, pytanieParameter, odpowiedzTypParameter);
        }
    
        public virtual int KiedunekStudentDodaj(Nullable<int> student_ID, Nullable<System.DateTime> data_OD, Nullable<System.DateTime> data_DO)
        {
            var student_IDParameter = student_ID.HasValue ?
                new ObjectParameter("Student_ID", student_ID) :
                new ObjectParameter("Student_ID", typeof(int));
    
            var data_ODParameter = data_OD.HasValue ?
                new ObjectParameter("Data_OD", data_OD) :
                new ObjectParameter("Data_OD", typeof(System.DateTime));
    
            var data_DOParameter = data_DO.HasValue ?
                new ObjectParameter("Data_DO", data_DO) :
                new ObjectParameter("Data_DO", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("KiedunekStudentDodaj", student_IDParameter, data_ODParameter, data_DOParameter);
        }
    
        public virtual int KierunekDodaj(string nazwa, string uczelniaNazwa)
        {
            var nazwaParameter = nazwa != null ?
                new ObjectParameter("Nazwa", nazwa) :
                new ObjectParameter("Nazwa", typeof(string));
    
            var uczelniaNazwaParameter = uczelniaNazwa != null ?
                new ObjectParameter("UczelniaNazwa", uczelniaNazwa) :
                new ObjectParameter("UczelniaNazwa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("KierunekDodaj", nazwaParameter, uczelniaNazwaParameter);
        }
    
        public virtual int PracodawcaAdresDodaj(Nullable<int> adres_ID, Nullable<System.DateTime> data_OD, Nullable<System.DateTime> data_DO)
        {
            var adres_IDParameter = adres_ID.HasValue ?
                new ObjectParameter("Adres_ID", adres_ID) :
                new ObjectParameter("Adres_ID", typeof(int));
    
            var data_ODParameter = data_OD.HasValue ?
                new ObjectParameter("Data_OD", data_OD) :
                new ObjectParameter("Data_OD", typeof(System.DateTime));
    
            var data_DOParameter = data_DO.HasValue ?
                new ObjectParameter("Data_DO", data_DO) :
                new ObjectParameter("Data_DO", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PracodawcaAdresDodaj", adres_IDParameter, data_ODParameter, data_DOParameter);
        }
    
        public virtual int PracodawcaDodaj(string symbol, string nazwa, string nIP, string rEGON, string email)
        {
            var symbolParameter = symbol != null ?
                new ObjectParameter("Symbol", symbol) :
                new ObjectParameter("Symbol", typeof(string));
    
            var nazwaParameter = nazwa != null ?
                new ObjectParameter("Nazwa", nazwa) :
                new ObjectParameter("Nazwa", typeof(string));
    
            var nIPParameter = nIP != null ?
                new ObjectParameter("NIP", nIP) :
                new ObjectParameter("NIP", typeof(string));
    
            var rEGONParameter = rEGON != null ?
                new ObjectParameter("REGON", rEGON) :
                new ObjectParameter("REGON", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PracodawcaDodaj", symbolParameter, nazwaParameter, nIPParameter, rEGONParameter, emailParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int StazDodaj(Nullable<int> pracodawca_ID, Nullable<int> stazPraktykaTyp_ID, string stazNazwa, string stazProgram, Nullable<System.DateTime> data_OD, Nullable<System.DateTime> data_DO, Nullable<int> ile_osob, Nullable<decimal> stawka, Nullable<bool> status_ID)
        {
            var pracodawca_IDParameter = pracodawca_ID.HasValue ?
                new ObjectParameter("Pracodawca_ID", pracodawca_ID) :
                new ObjectParameter("Pracodawca_ID", typeof(int));
    
            var stazPraktykaTyp_IDParameter = stazPraktykaTyp_ID.HasValue ?
                new ObjectParameter("StazPraktykaTyp_ID", stazPraktykaTyp_ID) :
                new ObjectParameter("StazPraktykaTyp_ID", typeof(int));
    
            var stazNazwaParameter = stazNazwa != null ?
                new ObjectParameter("StazNazwa", stazNazwa) :
                new ObjectParameter("StazNazwa", typeof(string));
    
            var stazProgramParameter = stazProgram != null ?
                new ObjectParameter("StazProgram", stazProgram) :
                new ObjectParameter("StazProgram", typeof(string));
    
            var data_ODParameter = data_OD.HasValue ?
                new ObjectParameter("Data_OD", data_OD) :
                new ObjectParameter("Data_OD", typeof(System.DateTime));
    
            var data_DOParameter = data_DO.HasValue ?
                new ObjectParameter("Data_DO", data_DO) :
                new ObjectParameter("Data_DO", typeof(System.DateTime));
    
            var ile_osobParameter = ile_osob.HasValue ?
                new ObjectParameter("Ile_osob", ile_osob) :
                new ObjectParameter("Ile_osob", typeof(int));
    
            var stawkaParameter = stawka.HasValue ?
                new ObjectParameter("Stawka", stawka) :
                new ObjectParameter("Stawka", typeof(decimal));
    
            var status_IDParameter = status_ID.HasValue ?
                new ObjectParameter("Status_ID", status_ID) :
                new ObjectParameter("Status_ID", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StazDodaj", pracodawca_IDParameter, stazPraktykaTyp_IDParameter, stazNazwaParameter, stazProgramParameter, data_ODParameter, data_DOParameter, ile_osobParameter, stawkaParameter, status_IDParameter);
        }
    
        public virtual int StazPraktykaTypDodaj(string stazPraktykaTyp, string stazPraktykaTyp_Info)
        {
            var stazPraktykaTypParameter = stazPraktykaTyp != null ?
                new ObjectParameter("StazPraktykaTyp", stazPraktykaTyp) :
                new ObjectParameter("StazPraktykaTyp", typeof(string));
    
            var stazPraktykaTyp_InfoParameter = stazPraktykaTyp_Info != null ?
                new ObjectParameter("StazPraktykaTyp_Info", stazPraktykaTyp_Info) :
                new ObjectParameter("StazPraktykaTyp_Info", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StazPraktykaTypDodaj", stazPraktykaTypParameter, stazPraktykaTyp_InfoParameter);
        }
    
        public virtual int StazStudentAnkietaDodaj(Nullable<int> staz_ID, Nullable<int> ankieta_ID, Nullable<int> student_ID)
        {
            var staz_IDParameter = staz_ID.HasValue ?
                new ObjectParameter("Staz_ID", staz_ID) :
                new ObjectParameter("Staz_ID", typeof(int));
    
            var ankieta_IDParameter = ankieta_ID.HasValue ?
                new ObjectParameter("Ankieta_ID", ankieta_ID) :
                new ObjectParameter("Ankieta_ID", typeof(int));
    
            var student_IDParameter = student_ID.HasValue ?
                new ObjectParameter("Student_ID", student_ID) :
                new ObjectParameter("Student_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StazStudentAnkietaDodaj", staz_IDParameter, ankieta_IDParameter, student_IDParameter);
        }
    
        public virtual int StazStudentDodaj(Nullable<int> student_ID, Nullable<int> staz_ID)
        {
            var student_IDParameter = student_ID.HasValue ?
                new ObjectParameter("Student_ID", student_ID) :
                new ObjectParameter("Student_ID", typeof(int));
    
            var staz_IDParameter = staz_ID.HasValue ?
                new ObjectParameter("Staz_ID", staz_ID) :
                new ObjectParameter("Staz_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StazStudentDodaj", student_IDParameter, staz_IDParameter);
        }
    
        public virtual int StazStudentUmowaDodaj(Nullable<int> staz_ID, Nullable<int> umowa_ID, Nullable<int> student_ID)
        {
            var staz_IDParameter = staz_ID.HasValue ?
                new ObjectParameter("Staz_ID", staz_ID) :
                new ObjectParameter("Staz_ID", typeof(int));
    
            var umowa_IDParameter = umowa_ID.HasValue ?
                new ObjectParameter("Umowa_ID", umowa_ID) :
                new ObjectParameter("Umowa_ID", typeof(int));
    
            var student_IDParameter = student_ID.HasValue ?
                new ObjectParameter("Student_ID", student_ID) :
                new ObjectParameter("Student_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StazStudentUmowaDodaj", staz_IDParameter, umowa_IDParameter, student_IDParameter);
        }
    
        public virtual int StudentAdresDodaj(Nullable<int> student_ID, Nullable<int> adres_ID, Nullable<System.DateTime> data_OD, Nullable<System.DateTime> data_DO)
        {
            var student_IDParameter = student_ID.HasValue ?
                new ObjectParameter("Student_ID", student_ID) :
                new ObjectParameter("Student_ID", typeof(int));
    
            var adres_IDParameter = adres_ID.HasValue ?
                new ObjectParameter("Adres_ID", adres_ID) :
                new ObjectParameter("Adres_ID", typeof(int));
    
            var data_ODParameter = data_OD.HasValue ?
                new ObjectParameter("Data_OD", data_OD) :
                new ObjectParameter("Data_OD", typeof(System.DateTime));
    
            var data_DOParameter = data_DO.HasValue ?
                new ObjectParameter("Data_DO", data_DO) :
                new ObjectParameter("Data_DO", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StudentAdresDodaj", student_IDParameter, adres_IDParameter, data_ODParameter, data_DOParameter);
        }
    
        public virtual int StudentDodaj(string imie, string nazwisko, Nullable<long> pESEL)
        {
            var imieParameter = imie != null ?
                new ObjectParameter("Imie", imie) :
                new ObjectParameter("Imie", typeof(string));
    
            var nazwiskoParameter = nazwisko != null ?
                new ObjectParameter("Nazwisko", nazwisko) :
                new ObjectParameter("Nazwisko", typeof(string));
    
            var pESELParameter = pESEL.HasValue ?
                new ObjectParameter("PESEL", pESEL) :
                new ObjectParameter("PESEL", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StudentDodaj", imieParameter, nazwiskoParameter, pESELParameter);
        }
    
        public virtual int UmowaDodaj(string umowaNR, Nullable<int> umowaWzor_ID, string trescUmowy)
        {
            var umowaNRParameter = umowaNR != null ?
                new ObjectParameter("UmowaNR", umowaNR) :
                new ObjectParameter("UmowaNR", typeof(string));
    
            var umowaWzor_IDParameter = umowaWzor_ID.HasValue ?
                new ObjectParameter("UmowaWzor_ID", umowaWzor_ID) :
                new ObjectParameter("UmowaWzor_ID", typeof(int));
    
            var trescUmowyParameter = trescUmowy != null ?
                new ObjectParameter("TrescUmowy", trescUmowy) :
                new ObjectParameter("TrescUmowy", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UmowaDodaj", umowaNRParameter, umowaWzor_IDParameter, trescUmowyParameter);
        }
    
        public virtual int UmowaWzorDodaj(string umowaNazwa, Nullable<bool> aktywnyWzor, string wersja, string trescUmowy)
        {
            var umowaNazwaParameter = umowaNazwa != null ?
                new ObjectParameter("UmowaNazwa", umowaNazwa) :
                new ObjectParameter("UmowaNazwa", typeof(string));
    
            var aktywnyWzorParameter = aktywnyWzor.HasValue ?
                new ObjectParameter("AktywnyWzor", aktywnyWzor) :
                new ObjectParameter("AktywnyWzor", typeof(bool));
    
            var wersjaParameter = wersja != null ?
                new ObjectParameter("Wersja", wersja) :
                new ObjectParameter("Wersja", typeof(string));
    
            var trescUmowyParameter = trescUmowy != null ?
                new ObjectParameter("TrescUmowy", trescUmowy) :
                new ObjectParameter("TrescUmowy", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UmowaWzorDodaj", umowaNazwaParameter, aktywnyWzorParameter, wersjaParameter, trescUmowyParameter);
        }
    
        public virtual int UmowaWzorZmienneDodaj(Nullable<int> umowaWzor_ID, string zmiennaNazwa, string zmiennaDefinicja)
        {
            var umowaWzor_IDParameter = umowaWzor_ID.HasValue ?
                new ObjectParameter("UmowaWzor_ID", umowaWzor_ID) :
                new ObjectParameter("UmowaWzor_ID", typeof(int));
    
            var zmiennaNazwaParameter = zmiennaNazwa != null ?
                new ObjectParameter("ZmiennaNazwa", zmiennaNazwa) :
                new ObjectParameter("ZmiennaNazwa", typeof(string));
    
            var zmiennaDefinicjaParameter = zmiennaDefinicja != null ?
                new ObjectParameter("ZmiennaDefinicja", zmiennaDefinicja) :
                new ObjectParameter("ZmiennaDefinicja", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UmowaWzorZmienneDodaj", umowaWzor_IDParameter, zmiennaNazwaParameter, zmiennaDefinicjaParameter);
        }
    
        public virtual int UmowaZmienneDodaj(Nullable<int> umowa_ID, string zmiennaNazwa, string zmiennaWartosc)
        {
            var umowa_IDParameter = umowa_ID.HasValue ?
                new ObjectParameter("Umowa_ID", umowa_ID) :
                new ObjectParameter("Umowa_ID", typeof(int));
    
            var zmiennaNazwaParameter = zmiennaNazwa != null ?
                new ObjectParameter("ZmiennaNazwa", zmiennaNazwa) :
                new ObjectParameter("ZmiennaNazwa", typeof(string));
    
            var zmiennaWartoscParameter = zmiennaWartosc != null ?
                new ObjectParameter("ZmiennaWartosc", zmiennaWartosc) :
                new ObjectParameter("ZmiennaWartosc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UmowaZmienneDodaj", umowa_IDParameter, zmiennaNazwaParameter, zmiennaWartoscParameter);
        }
    
        public virtual int UsersDodaj(string login, string password, string imie, string nazwisko, Nullable<int> userTyp)
        {
            var loginParameter = login != null ?
                new ObjectParameter("Login", login) :
                new ObjectParameter("Login", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var imieParameter = imie != null ?
                new ObjectParameter("Imie", imie) :
                new ObjectParameter("Imie", typeof(string));
    
            var nazwiskoParameter = nazwisko != null ?
                new ObjectParameter("Nazwisko", nazwisko) :
                new ObjectParameter("Nazwisko", typeof(string));
    
            var userTypParameter = userTyp.HasValue ?
                new ObjectParameter("UserTyp", userTyp) :
                new ObjectParameter("UserTyp", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UsersDodaj", loginParameter, passwordParameter, imieParameter, nazwiskoParameter, userTypParameter);
        }
    
        [DbFunction("Z707_PZEntities3", "getAnkieta")]
        public virtual IQueryable<getAnkieta_Result> getAnkieta(Nullable<int> ankieta_ID)
        {
            var ankieta_IDParameter = ankieta_ID.HasValue ?
                new ObjectParameter("Ankieta_ID", ankieta_ID) :
                new ObjectParameter("Ankieta_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<getAnkieta_Result>("[Z707_PZEntities3].[getAnkieta](@Ankieta_ID)", ankieta_IDParameter);
        }
    
        [DbFunction("Z707_PZEntities3", "getAnkietaWzor")]
        public virtual IQueryable<getAnkietaWzor_Result> getAnkietaWzor(Nullable<int> ankietaWzor_ID)
        {
            var ankietaWzor_IDParameter = ankietaWzor_ID.HasValue ?
                new ObjectParameter("AnkietaWzor_ID", ankietaWzor_ID) :
                new ObjectParameter("AnkietaWzor_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<getAnkietaWzor_Result>("[Z707_PZEntities3].[getAnkietaWzor](@AnkietaWzor_ID)", ankietaWzor_IDParameter);
        }
    
        [DbFunction("Z707_PZEntities3", "getAnkietaWzorOdpowiedz")]
        public virtual IQueryable<getAnkietaWzorOdpowiedz_Result> getAnkietaWzorOdpowiedz(Nullable<int> ankietaWzorPytanie_ID)
        {
            var ankietaWzorPytanie_IDParameter = ankietaWzorPytanie_ID.HasValue ?
                new ObjectParameter("AnkietaWzorPytanie_ID", ankietaWzorPytanie_ID) :
                new ObjectParameter("AnkietaWzorPytanie_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<getAnkietaWzorOdpowiedz_Result>("[Z707_PZEntities3].[getAnkietaWzorOdpowiedz](@AnkietaWzorPytanie_ID)", ankietaWzorPytanie_IDParameter);
        }
    
        [DbFunction("Z707_PZEntities3", "getAnkietaWzorPytanie")]
        public virtual IQueryable<getAnkietaWzorPytanie_Result> getAnkietaWzorPytanie(Nullable<int> ankietaWzor_ID)
        {
            var ankietaWzor_IDParameter = ankietaWzor_ID.HasValue ?
                new ObjectParameter("AnkietaWzor_ID", ankietaWzor_ID) :
                new ObjectParameter("AnkietaWzor_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<getAnkietaWzorPytanie_Result>("[Z707_PZEntities3].[getAnkietaWzorPytanie](@AnkietaWzor_ID)", ankietaWzor_IDParameter);
        }
    
        [DbFunction("Z707_PZEntities3", "getStazAnkietaStudent")]
        public virtual IQueryable<getStazAnkietaStudent_Result> getStazAnkietaStudent(Nullable<int> ankieta_ID)
        {
            var ankieta_IDParameter = ankieta_ID.HasValue ?
                new ObjectParameter("Ankieta_ID", ankieta_ID) :
                new ObjectParameter("Ankieta_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<getStazAnkietaStudent_Result>("[Z707_PZEntities3].[getStazAnkietaStudent](@Ankieta_ID)", ankieta_IDParameter);
        }
    }
}
