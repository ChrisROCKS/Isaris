using System;

namespace Isaris.Entities
{
    public class InvoiceReportModel
    {
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public string Unit { get; set; }

        public decimal Price { get; set; }

        public string ClientName { get; set; }

        public string Address { get; set; }

        public string Telephone { get; set; }

        public DateTime Date { get; set; }

        public string SellerName { get; set; }

        public int InvoiceId { get; set; }

        public string ProductName { get; set; }

        public decimal Value { get; set; }

        public decimal Discount { get; set; }

        public decimal Total { get; set; }

        public bool IsCanceled { get; set; }
    }
}
