using Gestion_De_Empleados_2._0.Dao;
using Gestion_De_Empleados_2._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Empleados_2._0.Helpers.HelpCargos
{
    public class WMHelperCargos
    {
        private static CargoDao Dao = new CargoDao();

        public static void Seed()
        {
            Cargo ob1 = new Cargo
            {
                Id = 1,
                Nombre = "Gerente",
                Funciones = "Gestionar el equipo y tomar decisiones estratégicas."

            };

            Cargo ob2 = new Cargo
            {
                Id = 2,
                Nombre = "Desarrollador",
                Funciones = "Escribir y mantener el código del software."
            };

            Dao.add(ob1);
            Dao.add(ob2);
        }
    }
}
