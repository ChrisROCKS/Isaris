using Isaris.BusinessLayer;
using Isaris.DataAccess.Contexts;
using Isaris.DataAccess.Models;
using Isaris.DataAccess.Repositories;
using Ninject.Modules;

namespace Isaris
{
    public class DependencyModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IsarisContext>().ToSelf();
            Bind<FormFactory>().ToSelf();
            Bind<ProductManager>().ToSelf();
            Bind<BaseRepository<Product>>().To<ProductRepository>();
            Bind<BaseRepository<Invoice>>().To<InvoiceRepository>();
        }
    }
}
