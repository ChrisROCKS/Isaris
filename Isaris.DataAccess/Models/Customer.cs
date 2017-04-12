namespace Isaris.DataAccess.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("clientes")]
    public class Customer
    {
        [Key]
        [Column("codcliente")]
        public int Id { get; set; }

        [StringLength(255)]
        [Column("nombre")]
        public string Name { get; set; }

        [StringLength(255)]
        [Column("direccion")]
        public string Address { get; set; }

        [StringLength(11)]
        [Column("telefono")]
        public string Telephone { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
