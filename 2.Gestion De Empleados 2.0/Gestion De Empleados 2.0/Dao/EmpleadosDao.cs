using Gestion_De_Empleados_2._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gestion_De_Empleados_2._0.Dao
{
    public class EmpleadosDao
    {
         
       private static List<Empleados> ls = new List<Empleados>();

        public List<Empleados> GetAll()
        {
            return ls;
        }

        public Empleados? GetById(int id)
        {
            foreach (var x in ls)
            {
                if (x.Id == id)
                {
                    return x;
                }

            }
            return null;
        }

        public void Add(Empleados ob)
        {
            var x = GetById(ob.Id);
            if (x == null)
            {
                ls.Add(ob);
            }
            else
            {
                ob.Id = x.Id;
                ob.Nombre = x.Nombre;
                ob.Apellido = x.Apellido;
                ob.Salario = x.Salario;
                ob.Genero = x.Genero;
                ob.Cargo = x.Cargo;

            }
        }

        public void Update(Empleados ob)
        {
            var x = GetById(ob.Id);
            if (x != null)
            {
                x.Nombre = ob.Nombre;
                x.Apellido = ob.Apellido;
                x.FechaDeIngreso = ob.FechaDeIngreso;
                x.Genero = ob.Genero;
                x.Cargo = ob.Cargo;
                x.Salario = ob.Salario;
                x.Foto = ob.Foto;
            }
        }

        public void Delete(int id)
        {
            var x = GetById(id);
            if (x != null)
            {
                ls.Remove(x);
            }
        }

    }
}
    

