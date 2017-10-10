using System;
using System.Windows.Forms;

namespace Isaris
{
    static class Program
    {

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CompositionRoot.Wire(new DependencyModule());
            Application.Run(CompositionRoot.Resolve<Menu>());
        }
    }
}
