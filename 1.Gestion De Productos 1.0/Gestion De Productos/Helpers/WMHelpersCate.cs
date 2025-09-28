using Gestion_De_Productos.DAO;
using Gestion_De_Productos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Productos.Helpers
{
    public class WMHelpersCate
    {
        private static CategoriaDao dao = new CategoriaDao();
        
        public static void semilla()
        {
            Categorias ob1 = new Categorias()
            {
                identificacion = 1,
                Nombre = "Juan".ToUpper()

            };

            Categorias ob2 = new Categorias()
            {
                identificacion = 2,
                Nombre = "Luigi".ToUpper(),
            };

            dao.agregarcate(ob1);
            dao.agregarcate(ob2);
        }
    }
}
