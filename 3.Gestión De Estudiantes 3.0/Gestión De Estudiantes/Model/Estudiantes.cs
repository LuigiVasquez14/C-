using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_De_Estudiantes.Model
{
    public class Estudiantes
    {
        public int Id { get; set; }

        public String Nombre { get; set; } = "";

        public String Apellido { get; set; } = "";

        public String TipoSangre { get; set; } = "";

        public decimal Peso { get; set; }

        public decimal Estatura { get; set; }

        public String Correo { get; set; } = "";

        public decimal Curso { get; set; }



       
        
    }
}
