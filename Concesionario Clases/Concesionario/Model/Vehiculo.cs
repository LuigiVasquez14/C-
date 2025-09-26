using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario.Model
{
    public class Vehiculo
    {
        public string Placa { get; set; } = "";
        public string Color { get; set; } = "";

        [DisplayName("Año de producción")]
        public int AnioProduccion { get; set; } = 0;
        public string Modelo { get; set; } = "";
        public string Foto { get; set; } = "";
        public int IdPropietario { get; set; }
        public int IdMarca { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}
