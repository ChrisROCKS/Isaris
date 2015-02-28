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
        public float existencia { get; set; }
        public string proveedor { get; set; }

        public string unidad { get; set; }
        public double precio { get; set; }
        public double precioTerranova { get; set; }
        //private bool disposed = false;

        //Implement IDisposable.
        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}

        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!disposed)
        //    {
        //        if (disposing)
        //        {
        //            // Free other state (managed objects).
        //        }
        //        // Free your own state (unmanaged objects).
        //        // Set large fields to null.
        //        disposed = true;
        //    }
        //}

        
    }
}
