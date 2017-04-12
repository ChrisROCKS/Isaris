using Isaris.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Isaris.DataAccess.Contexts;

namespace Isaris.DataAccess.Repositories
{
    public class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository(IsarisContext context) : base(context)
        {
        }

        public override IQueryable<Product> All()
        {
            return this.Context.Products;
        }

        protected override Product MapNewValuesToOld(Product oldEntity, Product newEntity)
        {
            oldEntity.Name = newEntity.Name;
            oldEntity.Price = newEntity.Price;
            oldEntity.PriceTerranova = newEntity.PriceTerranova;
            oldEntity.Provider = newEntity.Provider;
            oldEntity.Unit = newEntity.Unit;

            return oldEntity;
        }
    }
}
