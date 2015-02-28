using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isaris.Entities
{
    public class DetalleEntity
    {
        public int idDetalle { get; set; }
        public int idFactura { get; set; }
        public int idProd { get; set; }
        public float cantidad { get; set; }
        public string unidad { get; set; }
        public double precio { get; set; }
        public float valor { set; get; }
    }
}
