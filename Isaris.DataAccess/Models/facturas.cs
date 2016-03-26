using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isaris.DataAccess.Models
{
    public class facturas
    {
        public int codfactura { get; set; }
        public int codcliente { get; set; }
        public string vendedor { get; set; }
        public DateTime fecha { get; set; }
        public double descuento { get; set; }
        public double total { get; set; }
    }
}
