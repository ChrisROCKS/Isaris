using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;

namespace Isaris
{
    public class CompositionRoot
    {
        private static IKernel kernel;

        public static void Wire(INinjectModule module)
        {
            kernel = new StandardKernel(module);
        }

        public static T Resolve<T>()
        {
            return kernel.Get<T>();
        }
    }
}
