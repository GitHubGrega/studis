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
    
    public partial class izpitnirok
    {
        public izpitnirok()
        {
            this.ocenas = new HashSet<ocena>();
            this.students = new HashSet<student>();
        }
    
        public int id { get; set; }
        public System.DateTime datum { get; set; }
        public long predmetId { get; set; }
    
        public virtual predmet predmet { get; set; }
        public virtual ICollection<ocena> ocenas { get; set; }
        public virtual ICollection<student> students { get; set; }
    }
}
