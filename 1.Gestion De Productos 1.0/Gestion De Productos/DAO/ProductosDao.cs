using Gestion_De_Productos.DTO;
using Gestion_De_Productos.Helpers;
using Gestion_De_Productos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Productos.DAO
{
    public class ProductosDAO
    {
        private static List<GestionProductos> ls = new List<GestionProductos>();

        public List<GestionProductos> GetAll()
        {
            return ls;
        }

        public GestionProductos? GetById(int id)
        {
            foreach (var x in ls)
            {
                if (x.Id == id)
                    return x;
            }
            return null;
        }

        public void agregar(GestionProductos ob)
        {
            ls.Add(ob);
        }

        public void actualizar(GestionProductos ob)
        {
            var x = GetById(ob.Id);
            if (x != null)
            {
                x.Id = ob.Id;
                x.nombre = ob.nombre;
                x.cantidad = ob.cantidad;
                x.preciocompra = ob.preciocompra;
                x.precioventa = ob.precioventa;
                x.categoria = ob.categoria;
                x.disponible = ob.disponible;

            }
        }

        public void eliminar(int id)
        {
            var x = GetById(id);
            if (x != null)
                ls.Remove(x);
        }

       
    }
}
