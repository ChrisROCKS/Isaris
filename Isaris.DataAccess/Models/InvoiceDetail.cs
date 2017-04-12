namespace Isaris.DataAccess.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("detallefactura")]
    public class InvoiceDetail
    {
        [Key]
        [Column("coddetalle")]
        public int Id { get; set; }

        [Column("codfactura")]
        public int InvoiceId { get; set; }

        [Column("codproducto")]
        public int? ProductId { get; set; }

        [Column("unidad")]
        [StringLength(255)]
        public string Unit { get; set; }

        [Column("precio")]
        public decimal? Price { get; set; }

        [Column("cantidad")]
        public decimal? Quantity { get; set; }

        [Column("valor")]
        public decimal? Value { get; set; }

        public virtual Invoice Invoice { get; set; }

        public virtual Product Product { get; set; }
    }
}
