using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Productos.Model
{
    public class GestionProductos
    {
        public int Id { get; set; }
        public String nombre { get; set; } = "";

        public String cantidad { get; set; } = "";

        public String preciocompra { get; set; } = "";

        public String precioventa { get; set; } = "";

        public int categoria { get; set; }
        
        public bool disponible { get; set; }

        public Image picFoto { get; set; }

       
    }
}
