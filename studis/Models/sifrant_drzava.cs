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
    
    public partial class sifrant_drzava
    {
        public sifrant_drzava()
        {
            this.students = new HashSet<student>();
            this.students1 = new HashSet<student>();
            this.students2 = new HashSet<student>();
            this.students3 = new HashSet<student>();
        }
    
        public int id { get; set; }
        public string naziv { get; set; }
    
        public virtual ICollection<student> students { get; set; }
        public virtual ICollection<student> students1 { get; set; }
        public virtual ICollection<student> students2 { get; set; }
        public virtual ICollection<student> students3 { get; set; }
    }
}
