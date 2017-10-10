using System.Data;
using System.Collections.Generic;
using System.Linq;
using Isaris.DataAccess;
using Isaris.Entities;
using Isaris.DataAccess.Repositories;
using Isaris.DataAccess.Models;

namespace Isaris.BusinessLayer
{
    public class ProductManager
    {
        private readonly BaseRepository<Product> productRepository;

        public ProductManager(BaseRepository<Product> productRepository)
        {
            this.productRepository = productRepository;
        }

        public IEnumerable<ProductoEntity> All()
        {
            return this.productRepository.All().Select(x => new ProductoEntity
            {
                existencia = x.StockQuantity,
                IdProd = x.Id,
                nombre = x.Name,
                precio = x.Price,
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

        public void AddQuantity(int productId, decimal newQuantity)
        {
            var product = this.productRepository.FirstOrDefault(x => x.Id == productId);
            product.StockQuantity += newQuantity;
            this.productRepository.Update(product);
            this.productRepository.SaveChanges();
        }

        public void SubtractQuantity(int productId, decimal newQuantity)
        {
            var product = this.productRepository.FirstOrDefault(x => x.Id == productId);
            product.StockQuantity -= newQuantity;
            this.productRepository.Update(product);
            this.productRepository.SaveChanges();
        }

        public static void UpdateStock(int idProd, decimal Quantity)
        {
            ProductoDAL.UpdateStock(idProd, Quantity);
        }
        public void Save(ProductoEntity product)
        {
            if (ProductoDAL.Exists(product.IdProd))
            {
                productRepository.Update(new Product
                {
                    Id = product.IdProd,
                    Name = product.nombre,
                    Price = product.precio,
                    PriceTerranova = product.precioTerranova,
                    Provider = product.proveedor,
                    Unit = product.unidad
                });
                productRepository.SaveChanges();
            }
            else
            {
                ProductoDAL.Create(product);
            }
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