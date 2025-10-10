using Gestion_De_Empleados_2._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Empleados_2._0.Dao
{
    public class CargoDao
    {
        public static List<Cargo> ls = new List<Cargo> ();

        public List <Cargo> GetAll(int id = -1)
        {
            return ls;
        }

        public Cargo? GetById(int Id)
        {
            foreach (var x  in ls)
            {
                if (x.Id == Id)
                    return x;
            }
            return null;
        }
        public void add(Cargo ob)
        {
            ls.Add(ob);
        }

        public void update(Cargo ob)
        {
            var x = GetById(ob.Id);
            if (x != null)
            {
                x.Id = ob.Id;
                x.Nombre = ob.Nombre;
                x.Funciones = ob.Funciones;
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