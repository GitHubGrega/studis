//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace studis.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class sifrant_studijskiprogram
    {
        public sifrant_studijskiprogram()
        {
            this.predmets = new HashSet<predmet>();
            this.vpis = new HashSet<vpi>();
            this.vpis1 = new HashSet<vpi>();
            this.zetons = new HashSet<zeton>();
        }
    
        public int id { get; set; }
        public string naziv { get; set; }
    
        public virtual ICollection<predmet> predmets { get; set; }
        public virtual ICollection<vpi> vpis { get; set; }
        public virtual ICollection<vpi> vpis1 { get; set; }
        public virtual ICollection<zeton> zetons { get; set; }
    }
}
