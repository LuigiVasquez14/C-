using Gestion_De_Productos.DAO;
using Gestion_De_Productos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Productos.Helpers
{
    public class WMHelpers
    {
        private static ProductosDAO dao = new ProductosDAO();

        public static void Seed()
        {
            GestionProductos ob1 = new GestionProductos()
            {
                Id = 1,
                nombre = "Guillermo".ToUpper(),
                cantidad = "2".ToUpper(),
                preciocompra = "15000".ToUpper(),
                precioventa = "15000".ToUpper(),
                disponible = true,
                categoria = "Nevera".ToUpper(),




            };

            GestionProductos ob2 = new GestionProductos()
            {
                Id = 2,
                nombre = "Luigi".ToUpper(),
                cantidad = "2".ToUpper(),
                preciocompra = "15000".ToUpper(),
                precioventa = "35000".ToUpper(),
                disponible = false,
                categoria = "Refrigerador".ToUpper(),
            };

            dao.agregar(ob1);
            dao.agregar(ob2);
        }
    }
}
