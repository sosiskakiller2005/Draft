﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Draft.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class user10Entities : DbContext
    {
        public user10Entities()
            : base("name=user10Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<materials> materials { get; set; }
        public virtual DbSet<measure> measure { get; set; }
        public virtual DbSet<possible_supply> possible_supply { get; set; }
        public virtual DbSet<supply> supply { get; set; }
        public virtual DbSet<supply_type> supply_type { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<material_type> material_type { get; set; }
    }
}