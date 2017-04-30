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
        public int IdFactura { get; set; }
        public int IdCliente { get; set; }
        public string Vendedor { get; set; }
        public DateTime Fecha { get; set; }
        public List<DetalleEntity> Lineas { get; set; }

        public decimal Subtotal => this.Lineas.Sum(x => x.Precio * x.Cantidad); public decimal Descuento
        {
            get 
            { 
                return (Porcentaje /100) * this.Subtotal; 
            }
            set 
            { 
                Porcentaje = value; 
            }
        }
        public decimal Isv
        {
            get { return Subtotal * Convert.ToDecimal(0.15); }
        }

        public decimal Total
        {
            get { return (Subtotal + Isv)-Descuento; }
        }

        public decimal Porcentaje { get => porcentaje; set => porcentaje = value; }
    }
}
