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
    
    public partial class kandidat
    {
        public int id { get; set; }
        public string ime { get; set; }
        public string priimek { get; set; }
        public int studijskiProgram { get; set; }
        public string email { get; set; }
        public int userId { get; set; }
    
        public virtual my_aspnet_users my_aspnet_users { get; set; }
    }
}
