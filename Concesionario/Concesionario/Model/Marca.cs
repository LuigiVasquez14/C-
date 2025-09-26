using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario.Model
{
    public class Marca
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = "";
        
        [DisplayName("País de Origen")]
        public string PaisOrigen { get; set; } = "";

        public DateTime FechaCreacion { get; set; }

    }
}
