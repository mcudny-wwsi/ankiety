//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class AnkietaWzorOdpowiedz
    {
        public int AnkietaWzorOdpowiedz_ID { get; set; }
        public Nullable<int> AnkietaWzorPytanie_ID { get; set; }
        public Nullable<int> Odpowiedz_LP { get; set; }
        public string Odpowiedz { get; set; }
    
        public virtual AnkietaWzorPytanie AnkietaWzorPytanie { get; set; }
    }
}
