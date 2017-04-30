using System;
using System.Linq;
using Isaris.DataAccess.Contexts;
using Isaris.DataAccess.Models;

namespace Isaris.DataAccess.Repositories
{
    public class InvoiceRepository : BaseRepository<Invoice>
    {
        public InvoiceRepository(IsarisContext context) : base(context)
        {
        }

        public override IQueryable<Invoice> All()
        {
            return this.Context.Invoices;
        }

        protected override Invoice MapNewValuesToOld(Invoice oldEntity, Invoice newEntity)
        {
            oldEntity.Customer = newEntity.Customer;
            oldEntity.CustomerId = newEntity.CustomerId;
            oldEntity.Date = newEntity.Date;
            oldEntity.Discount = newEntity.Discount;
            oldEntity.InvoiceDetails = newEntity.InvoiceDetails;
            oldEntity.SellerName = newEntity.SellerName;
            oldEntity.Total = newEntity.Total;

            return oldEntity;
        }
    }
}
