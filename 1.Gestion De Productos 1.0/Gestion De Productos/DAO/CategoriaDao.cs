using Gestion_De_Productos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Productos.DAO
{
    public class CategoriaDao
    {
        private static List<Categorias> ls = new List<Categorias>();

        public List<Categorias> tenertodo()
        {
            return ls;
        }

        public Categorias? Conseguirporidentificacion(int id)
        {
            foreach(var x in ls)
            {
                if (x.identificacion==id)
                    return x;
            }
            return null;
        }
        public void agregarcate(Categorias ob)
        {
            ls.Add(ob);
        }



        private void actualizar (Categorias ob)
        {
            var x = Conseguirporidentificacion(ob.identificacion);
            if (x!=null)
            {
                x.identificacion = ob.identificacion;
                x.Nombre = ob.Nombre;
            }
        }
        public void eliminar (int id)
        {
            var x = Conseguirporidentificacion(id);
            if (x != null)
                ls.Remove(x);
        }
    }
}
