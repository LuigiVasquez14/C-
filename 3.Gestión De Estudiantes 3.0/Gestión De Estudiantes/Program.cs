using Gestión_De_Estudiantes.Helpers;
using Gestión_De_Estudiantes.UI;

namespace Gestión_De_Estudiantes
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
            LVHelper.Seed();
            Application.Run(new MainUI());
        }
    }
}

