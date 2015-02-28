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
        private double porcentaje;
        public int idFactura { get; set; }
        public int idCliente { get; set; }
        public string vendedor { get; set; }
        public DateTime fecha { get; set; }
        public List<DetalleEntity> Lineas { get; set; }

        public double subtotal
        {
            get { return this.Lineas.Sum(x => x.precio * x.cantidad); }
        }
        public double descuento
        {
            get 
            { 
                return (porcentaje /100)*this.subtotal; 
            }
            set 
            { 
                porcentaje = value; 
            }
        }
        public double isv
        {
            get { return subtotal * 0.15; }
        }

        public double total
        {
            get { return (subtotal + isv)-descuento; }
        }


        //// Has Dispose() already been called?
        //Boolean isDisposed = false;
        //// Implement IDisposable.
        //public void Dispose()
        //{
        //ReleaseResources(true); // cleans both unmanaged and managed resources
        //GC.SuppressFinalize(this); // supress finalization
        //}
 
        //protected void ReleaseResources(bool isFromDispose)
        //{
        //// Try to release resources only if they have not been previously released.
        //if (!isDisposed)
        //{
        //    if (isFromDispose)
        //    {
        //    // TODO: Release managed resources here
        //    // GC will automatically release Managed resources by calling the destructor,
        //    // but Dispose() need to release managed resources manually
        //    }
        //    //TODO: Release unmanaged resources here
        //}
        //isDisposed = true; // Dispose() can be called numerous times
        //}
        //// Use C# destructor syntax for finalization code, invoked by GC only.
        //~FacturaEntity()
        //{
        //    // cleans only unmanaged stuffs
        //    ReleaseResources(false);
        //}

    }
}
