﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Reem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class REEMBOLSOEntities : DbContext
    {
        public REEMBOLSOEntities()
            : base("name=REEMBOLSOEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Acreedor> Acreedor { get; set; }
        public DbSet<Articulo> Articulo { get; set; }
        public DbSet<Modulo> Modulo { get; set; }
        public DbSet<Paquete> Paquete { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Reembolso> Reembolso { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Segmento> Segmento { get; set; }
        public DbSet<StatusPaq> StatusPaq { get; set; }
        public DbSet<Sucursal> Sucursal { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Usuario_Modulo> Usuario_Modulo { get; set; }
    }
}
