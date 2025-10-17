using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Empleados_2._0.Model
{
    public class Empleados
    {
        public int Id { get; set; }
        public String Nombre { get; set; } = "";
        public String Apellido { get; set; } = "";
        public DateTime FechaDeIngreso { get; set; }
        public String Genero { get; set; } = "";
        public String Cargo { get; set; } = "";
        public double Salario { get; set; }
        public byte Foto { get; set; }

    }
}


//(id, nombre, apellido, fecha de ingreso, genero, cargo, salario, foto)