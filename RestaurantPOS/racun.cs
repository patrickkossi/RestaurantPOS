//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantPOS
{
    using System;
    using System.Collections.Generic;
    
    public partial class racun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public racun()
        {
            this.stavkeRacunas = new HashSet<stavkeRacuna>();
        }
    
        public int idRacun { get; set; }
        public string JIR { get; set; }
        public string vrijeme { get; set; }
        public Nullable<decimal> ukupnoPrijePoreza { get; set; }
        public Nullable<decimal> ukupnoPoslijePoreza { get; set; }
        public int idKorisnik { get; set; }
        public string oibPravneOsobe { get; set; }
        public Nullable<int> idPoreza { get; set; }
    
        public virtual korisnik korisnik { get; set; }
        public virtual porez porez { get; set; }
        public virtual pravneOsobe pravneOsobe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stavkeRacuna> stavkeRacunas { get; set; }
    }
}