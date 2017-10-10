using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isaris.Entities
{
    public class DetalleEntity
    {
        public int IdDetalle { get; set; }
        public int IdFactura { get; set; }
        public int IdProd { get; set; }
        public decimal Cantidad { get; set; }
        public string Unidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Valor { set; get; }
    }
}
