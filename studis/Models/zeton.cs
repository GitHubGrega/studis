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
    
    public partial class zeton
    {
        public int vpisnaStevilka { get; set; }
        public int letnik { get; set; }
        public int studijskiProgram { get; set; }
        public bool porabljen { get; set; }
        public int vrstaVpisa { get; set; }
        public int vrstaStudija { get; set; }
        public int oblikaStudija { get; set; }
    
        public virtual sifrant_klasius sifrant_klasius { get; set; }
        public virtual sifrant_letnik sifrant_letnik { get; set; }
        public virtual sifrant_oblikastudija sifrant_oblikastudija { get; set; }
        public virtual sifrant_studijskiprogram sifrant_studijskiprogram { get; set; }
        public virtual sifrant_vrstavpisa sifrant_vrstavpisa { get; set; }
        public virtual student student { get; set; }
    }
}
