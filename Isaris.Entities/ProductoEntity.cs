using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isaris.Entities
{
    public class ProductoEntity
    {
        public int idProd { get; set; }
        public string nombre { get; set; }
        public decimal existencia { get; set; }
        public string proveedor { get; set; }

        public string unidad { get; set; }
        public decimal precio { get; set; }
        public decimal precioTerranova { get; set; }
    }
}
