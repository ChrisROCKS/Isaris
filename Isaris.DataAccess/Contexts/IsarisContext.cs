using Isaris.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isaris.DataAccess.Contexts
{
    public class IsarisContext : DbContext
    {
        public IsarisContext()
            : base("name=default")
        {
            this.Database.Log += s => Debug.WriteLine(s);
        }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }

        public virtual DbSet<Invoice> Invoices { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<string>().Configure(x => x.IsUnicode(false));

        }
    }
}
