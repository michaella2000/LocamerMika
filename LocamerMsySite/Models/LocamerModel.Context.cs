﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LocamerMsySite.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LocamerMsyEntities1 : DbContext
    {
        public LocamerMsyEntities1()
            : base("name=LocamerMsyEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categorie> Categorie { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Emplacement> Emplacement { get; set; }
        public virtual DbSet<Option> Option { get; set; }
        public virtual DbSet<Option_sejour> Option_sejour { get; set; }
        public virtual DbSet<Sejour> Sejour { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Type_sejour> Type_sejour { get; set; }
    }
}
