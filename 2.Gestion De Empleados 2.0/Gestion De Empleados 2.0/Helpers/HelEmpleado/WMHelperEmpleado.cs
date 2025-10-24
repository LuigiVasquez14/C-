using Gestion_De_Empleados_2._0.Dao;
using Gestion_De_Empleados_2._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Empleados_2._0.Helpers.HelEmpleado
{
    public class WMHelperEmpleado
    {
        private static EmpleadosDao dao = new EmpleadosDao();

        public static void Seed()
        {
            Empleados ob1 = new Empleados()
            {
                Id = 1,
                Nombre = "Juan",
                Apellido = "Perez",
                FechaDeIngreso = new DateTime(2020, 1, 15),
                Genero = "Masculino",
                Cargo = "Desarrollador",
                Salario = 50000,


            };

            Empleados ob2 = new Empleados()
            {
                Id = 2,
                Nombre = "Maria",
                Apellido = "Gomez",
                FechaDeIngreso = new DateTime(2019, 3, 22),
                Genero = "Femenino",
                Cargo = "Diseñadora",
                Salario = 45000,

            };

            dao.Add(ob1);
            dao.Add(ob2);
        }

        public static List<Empleados> OrdenarPorSalario(string orden, double salario = 0)
        {
            var lista = dao.GetAll();

            switch ((orden ?? "").Trim().ToLowerInvariant())
            {
                case "mayor":
                    return lista.OrderByDescending(p => p.Salario).ToList();

                case "menor":
                    return lista.OrderBy(p => p.Salario).ToList();

                case "igual":
                    return lista.Where(p => p.Salario == salario).ToList();

                default:
                    return lista;
            }
        }
    }
}
