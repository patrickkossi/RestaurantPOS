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
    
    public partial class stavkeRacuna
    {
        public int idStavkeRacuna { get; set; }
        public int idRacun { get; set; }
        public Nullable<int> idProizvod { get; set; }
        public Nullable<int> idMeni { get; set; }
    
        public virtual meni meni { get; set; }
        public virtual proizvod proizvod { get; set; }
        public virtual racun racun { get; set; }
    }
}
