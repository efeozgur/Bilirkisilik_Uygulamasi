﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bilirkisilik_Uygulamasi.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBBILIRKISIEntities1 : DbContext
    {
        public DBBILIRKISIEntities1()
            : base("name=DBBILIRKISIEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBL_BILIRKISILER> TBL_BILIRKISILER { get; set; }
        public virtual DbSet<TBL_BILIRKISILIK> TBL_BILIRKISILIK { get; set; }
        public virtual DbSet<TBL_BIRIMLER> TBL_BIRIMLER { get; set; }
        public virtual DbSet<TBL_RAPORTURU> TBL_RAPORTURU { get; set; }
    }
}
