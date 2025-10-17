using Gestión_De_Estudiantes.Dao;
using Gestión_De_Estudiantes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_De_Estudiantes.Helpers
{
    public class LVHelper
    {
        private static EstudiantesDAO dao = new EstudiantesDAO();

        public static void Seed()
        {
            Estudiantes ob1 = new Estudiantes()
            {
                Id = 1,
                Nombre = "Luigi",
                Apellido = "Vasquez",
                TipoSangre = "O+",
                Peso = 70.5m,
                Estatura = 1.75m,
                Correo = "Luigivsqz4@gmail.com",
                Curso = 9,
            };

            Estudiantes ob2 = new Estudiantes()
            {
                Id = 2,
                Nombre = "María",
                Apellido = "Gómez",
                TipoSangre = "A-",
                Peso = 60.0m,
                Estatura = 1.65m,
                Correo = "MariaGomez@gmail.com",
                Curso = 11,

            };
            dao.Add(ob1);
            dao.Add(ob2);
        }
        public static List<Estudiantes>OrdenarPorSangre()
            {
            var lista = dao.GetAll();
            var listaOrdenada = lista.OrderBy(e => e.TipoSangre).ToList();
            return listaOrdenada;
        }

        public static List<Estudiantes> FiltrarPorCurso(decimal curso)
        {
            var lista = dao.GetAll();
            var listaFiltrada = lista.Where(e => e.Curso == curso).ToList();
            return listaFiltrada;
        }

        public static List<Estudiantes>OrdenarPorPeso()
        {
            var lista = dao.GetAll();
            var listaOrdenada = lista.OrderBy(e => e.Peso).ToList();
            return listaOrdenada;
        }

        public static List<Estudiantes> FiltrarPorEstatura(decimal estatura)
        {
            var lista = dao.GetAll();
            var listaFiltrada = lista.Where(e => e.Estatura == estatura).ToList();
            return listaFiltrada;
        }

    }
}
