﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceManagementSystem.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ServiceManagmentSystemEntities2 : DbContext
    {
        public ServiceManagmentSystemEntities2()
            : base("name=ServiceManagmentSystemEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Asset> Assets { get; set; }
        public virtual DbSet<AssetLocation> AssetLocations { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<RequestStatu> RequestStatus { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleUserMapping> RoleUserMappings { get; set; }
        public virtual DbSet<RequestTracking> RequestTrackings { get; set; }
    }
}
