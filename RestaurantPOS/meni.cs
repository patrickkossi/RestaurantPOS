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
    
    public partial class meni
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public meni()
        {
            this.stavkeRacunas = new HashSet<stavkeRacuna>();
            this.proizvods = new HashSet<proizvod>();
        }
    
        public int idMeni { get; set; }
        public string naziv { get; set; }
        public string datum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stavkeRacuna> stavkeRacunas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<proizvod> proizvods { get; set; }
        nesto noest

    }
}
