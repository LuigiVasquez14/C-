using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Empleados_2._0.Model
{
    public class Cargo
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Funciones { get; set; } = "";

    }
}
//(id, nombre, funciones).