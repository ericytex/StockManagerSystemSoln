﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockManagerSystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StkManagementSystemEntitiesDiagnosisModel : DbContext
    {
        public StkManagementSystemEntitiesDiagnosisModel()
            : base("name=StkManagementSystemEntitiesDiagnosisModel")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<createPatientInvoice> createPatientInvoices { get; set; }
        public virtual DbSet<createSupplierInvoice> createSupplierInvoices { get; set; }
        public virtual DbSet<diagnosi> diagnosis { get; set; }
        public virtual DbSet<expensesLog> expensesLogs { get; set; }
        public virtual DbSet<itemPrice> itemPrices { get; set; }
        public virtual DbSet<logBankDetail> logBankDetails { get; set; }
        public virtual DbSet<patient> patients { get; set; }
        public virtual DbSet<placeOrder> placeOrders { get; set; }
        public virtual DbSet<stockLog> stockLogs { get; set; }
        public virtual DbSet<supplier> suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<userRight> userRights { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}
