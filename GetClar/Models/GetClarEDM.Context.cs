﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GetClar.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GetClarEntities : DbContext
    {
        public GetClarEntities()
            : base("name=GetClarEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CollegeId> CollegeIds { get; set; }
        public virtual DbSet<MemberLogin> MemberLogins { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Specialization> Specializations { get; set; }
        public virtual DbSet<StaffSpecialization> StaffSpecializations { get; set; }
    }
}
