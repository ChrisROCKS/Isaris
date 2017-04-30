using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isaris.Entities
{
    public class FacturaEntity
    {
        public FacturaEntity()
        {
            this.Lineas = new List<DetalleEntity>();
        }
        private decimal porcentaje;
        public int idFactura { get; set; }
        public int idCliente { get; set; }
        public string vendedor { get; set; }
        public DateTime fecha { get; set; }
        public List<DetalleEntity> Lineas { get; set; }

        public decimal subtotal
        {
            get { return this.Lineas.Sum(x => x.precio * x.cantidad); }
        }
        public decimal descuento
        {
            get 
            { 
                return (porcentaje /100) * this.subtotal; 
            }
            set 
            { 
                porcentaje = value; 
            }
        }
        public decimal isv
        {
            get { return subtotal * Convert.ToDecimal(0.15); }
        }

        public decimal total
        {
            get { return (subtotal + isv)-descuento; }
        }
    }
}
