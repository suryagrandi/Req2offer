﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNetReq2Offer.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Req2offerDBEntities1 : DbContext
    {
        public Req2offerDBEntities1()
            : base("name=Req2offerDBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbl_Business_Unit> tbl_Business_Unit { get; set; }
        public virtual DbSet<tbl_Cost_Center> tbl_Cost_Center { get; set; }
        public virtual DbSet<tbl_Customer> tbl_Customer { get; set; }
        public virtual DbSet<tbl_Employee_Type> tbl_Employee_Type { get; set; }
        public virtual DbSet<tbl_External_Req> tbl_External_Req { get; set; }
        public virtual DbSet<tbl_Internal_Req> tbl_Internal_Req { get; set; }
        public virtual DbSet<tbl_Role> tbl_Role { get; set; }
        public virtual DbSet<tbl_Select_Candidate> tbl_Select_Candidate { get; set; }
        public virtual DbSet<tbl_Status> tbl_Status { get; set; }
        public virtual DbSet<tbl_Sub_Business_Unit> tbl_Sub_Business_Unit { get; set; }
        public virtual DbSet<tbl_User> tbl_User { get; set; }
    }
}
