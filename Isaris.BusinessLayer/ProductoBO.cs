using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Isaris.DataAccess;
using Isaris.Entities;
using System.Windows.Forms;

namespace Isaris.Negocio
{
    public class ProductoBO
    {
        public static ProductoEntity GetByName(string nombre,string campoPrecio)
        {
            return ProductoDAL.GetByName(nombre,campoPrecio);
           
        }
        public static ProductoEntity Create(ProductoEntity prod)
        {
            return ProductoDAL.Create(prod);
        }
        //public static List<ProductoEntity> GetAll()
        //{
        //    return ProductoDAL.GetAll();
        //}
        public static void UpdateStock(int idProd, float Quantity)
        {
            ProductoDAL.UpdateStock(idProd, Quantity);
        }
        public static void Save(ProductoEntity prod)
        {
            if (ProductoDAL.Exists(prod.idProd))
                ProductoDAL.Update(prod);
            else
                ProductoDAL.Create(prod);
        }
        public static ProductoEntity GetById(int id)
        {
            return ProductoDAL.GetById(id);

        }
        public static ProductoEntity Update(ProductoEntity prod)
        {
            return ProductoDAL.Update(prod);

        }
    }

}
