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
            this.Database.Log = s => Debug.WriteLine(s);
        }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }

        public virtual DbSet<Invoice> Invoices { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.SellerName)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Provider)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Unit)
                .IsUnicode(false);
        }
    }
}
