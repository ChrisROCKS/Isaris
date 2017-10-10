using System;

namespace Isaris.Entities
{
    public class InvoiceReportModel
    {
        public int ProductId { get; set; }

        public decimal Quantity { get; set; }

        public string Unit { get; set; }

        public decimal Price { get; set; }

        public string ClientName { get; set; }

        public string Address { get; set; }

        public string Telephone { get; set; }

        public DateTime Date { get; set; }

        public string SellerName { get; set; }

        public int InvoiceId { get; set; }

        public string ProductName { get; set; }

        public decimal Value => this.Price * Quantity;

        public decimal Discount { get; set; }

        public decimal Isv { get; set; }

        public decimal Total { get; set; }

        public bool IsCanceled { get; set; }
    }
}
