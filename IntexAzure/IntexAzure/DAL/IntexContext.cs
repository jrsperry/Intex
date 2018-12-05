using IntexAzure.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IntexAzure.DAL
{
    public class IntexContext : DbContext
    {
        public IntexContext() : base("IntexContext")
        {
        }

        public DbSet<Customers> Customer { get; set; }
        public DbSet<Assays> Assay { get; set; }
        public DbSet<AssayTypes> AssayType { get; set; }
        public DbSet<WorkOrders> WorkOrder { get; set; }
        public DbSet<Employees> Employee { get; set; }

    }
}