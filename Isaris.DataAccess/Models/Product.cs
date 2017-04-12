using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Isaris.DataAccess.Models
{
    [Table("inventario")]
    public class Product
    {
        [Key]
        [Column("codproducto", TypeName = "uint")]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Column("nombre")]
        public string Name { get; set; }

        [Column("precio")]
        public decimal Price { get; set; }

        [Column("precioTerranova")]
        public decimal? PriceTerranova { get; set; }

        [Column("existencia")]
        public decimal StockQuantity { get; set; }

        [Required]
        [StringLength(255)]
        [Column("proveedor")]
        public string Provider { get; set; }

        [StringLength(255)]
        [Column("unidad")]
        public string Unit { get; set; }
    }
}
