﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class studisEntities : DbContext
    {
        public studisEntities()
            : base("name=studisEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<my_aspnet_applications> my_aspnet_applications { get; set; }
        public virtual DbSet<my_aspnet_membership> my_aspnet_membership { get; set; }
        public virtual DbSet<my_aspnet_paths> my_aspnet_paths { get; set; }
        public virtual DbSet<my_aspnet_personalizationallusers> my_aspnet_personalizationallusers { get; set; }
        public virtual DbSet<my_aspnet_personalizationperuser> my_aspnet_personalizationperuser { get; set; }
        public virtual DbSet<my_aspnet_profiles> my_aspnet_profiles { get; set; }
        public virtual DbSet<my_aspnet_roles> my_aspnet_roles { get; set; }
        public virtual DbSet<my_aspnet_sessioncleanup> my_aspnet_sessioncleanup { get; set; }
        public virtual DbSet<my_aspnet_sessions> my_aspnet_sessions { get; set; }
        public virtual DbSet<my_aspnet_sitemap> my_aspnet_sitemap { get; set; }
        public virtual DbSet<my_aspnet_users> my_aspnet_users { get; set; }
        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<ip_lock> ip_lock { get; set; }
    }
}
