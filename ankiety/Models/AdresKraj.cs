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
    
    public partial class AdresKraj
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AdresKraj()
        {
            this.Adres = new HashSet<Adres>();
        }
    
        public int AdresKraj_ID { get; set; }
        public string AdresKraj1 { get; set; }
        public string AdresKraj_Info { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adres> Adres { get; set; }
    }
}