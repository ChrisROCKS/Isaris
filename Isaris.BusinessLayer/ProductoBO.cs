﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Isaris.DataAccess;
using Isaris.Entities;
using System.Windows.Forms;
using Isaris.DataAccess.Repositories;
using Isaris.DataAccess.Models;
using Isaris.DataAccess.Contexts;

namespace Isaris.BusinessLayer
{
    public class ProductoBO
    {
        private readonly IsarisContext context = new IsarisContext();
        private readonly BaseRepository<Product> productRepository;
        public ProductoBO()
        {
            this.productRepository = new ProductRepository(context);
        }

        public IEnumerable<ProductoEntity> All()
        {
            return this.productRepository.All().Select(x => new ProductoEntity
            {
                existencia = x.StockQuantity,
                idProd = x.Id,
                nombre = x.Name,
                precio = x.Price,
                precioTerranova = x.PriceTerranova ?? 0,
                proveedor = x.Provider,
                unidad = x.Unit

            });
        }

        public static ProductoEntity GetByName(string nombre, string campoPrecio)
        {
            return ProductoDAL.GetByName(nombre, campoPrecio);

        }
        public static ProductoEntity Create(ProductoEntity prod)
        {
            return ProductoDAL.Create(prod);
        }

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
