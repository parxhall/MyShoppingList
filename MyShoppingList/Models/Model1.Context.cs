﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyShoppingList.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ShoppingDatabaseEntities : DbContext
    {
        public ShoppingDatabaseEntities()
            : base("name=ShoppingDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ITEM> ITEMS { get; set; }
        public virtual DbSet<JOINER> JOINERs { get; set; }
        public virtual DbSet<LIST> LISTs { get; set; }
        public virtual DbSet<PERSON> People { get; set; }
        public virtual DbSet<RECIPE> RECIPEs { get; set; }
        public virtual DbSet<SHIELDING> SHIELDINGs { get; set; }
        public virtual DbSet<STATUS> STATUS { get; set; }
    }
}
