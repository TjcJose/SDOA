﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sd.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SdEntities : DbContext
    {
        public SdEntities()
            : base("name=SdEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<UserGroup> UserGroup { get; set; }
        public virtual DbSet<gsxx> gsxx { get; set; }
        public virtual DbSet<CompetenceSet> CompetenceSet { get; set; }
        public virtual DbSet<password> password { get; set; }
        public virtual DbSet<khxx> khxx { get; set; }
        public virtual DbSet<zlb> zlb { get; set; }
        public virtual DbSet<bigDepartment> bigDepartment { get; set; }
        public virtual DbSet<xsbxx> xsbxx { get; set; }
        public virtual DbSet<zyxx> zyxx { get; set; }
    }
}
