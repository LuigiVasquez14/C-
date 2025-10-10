using Gestion_De_Empleados_2._0.Helpers.HelEmpleado;
using Gestion_De_Empleados_2._0.Helpers.HelpCargos;

namespace Gestion_De_Empleados_2._0
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            WMHelperEmpleado.Seed();
            WMHelperCargos.Seed();
            Application.Run(new DatosEmpleados());
        }
    }
}