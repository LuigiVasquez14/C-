using Gestión_De_Estudiantes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_De_Estudiantes.Dao
{
    public class EstudiantesDAO
    {
        private static List<Estudiantes> ls = new List<Estudiantes>();

        public List<Estudiantes> GetAll()
        {
            return ls;
        }

        public Estudiantes? getById(int id)
        {
            foreach (var x in ls)
            {
                if (x.Id == id)
                    return x;
            }
            return null;
        }

        public void Add(Estudiantes ob)
        {
            ls.Add(ob);
        }

        public void Update(Estudiantes ob)
        {
            var x = getById(ob.Id);
            if (x != null)
            {
                x.Nombre = ob.Nombre;
                x.Apellido = ob.Apellido;
                x.TipoSangre = ob.TipoSangre;
                x.Peso = ob.Peso;
                x.Estatura = ob.Estatura;
                x.Correo = ob.Correo;
                x.Curso = ob.Curso;
            }

           
        }
        public void Delete(int id)
        {
            var x = getById(id);
            if (x != null)
            {
                ls.Remove(x);
            }
        }
    }
}
