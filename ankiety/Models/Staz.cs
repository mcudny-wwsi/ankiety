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
    
    public partial class Staz
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staz()
        {
            this.StazStudentAnkieta = new HashSet<StazStudentAnkieta>();
        }
    
        public int Staz_ID { get; set; }
        public Nullable<int> Pracodawca_ID { get; set; }
        public Nullable<int> StazPraktykaTyp_ID { get; set; }
        public string StazNazwa { get; set; }
        public string StazProgram { get; set; }
        public Nullable<System.DateTime> Data_OD { get; set; }
        public Nullable<System.DateTime> Data_DO { get; set; }
        public Nullable<int> Ile_osob { get; set; }
        public Nullable<decimal> Stawka { get; set; }
        public Nullable<bool> Status_ID { get; set; }
    
        public virtual Pracodawca Pracodawca { get; set; }
        public virtual StazPraktykaTyp StazPraktykaTyp { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StazStudentAnkieta> StazStudentAnkieta { get; set; }
    }
}
