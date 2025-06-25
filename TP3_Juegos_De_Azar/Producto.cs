using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Juegos_De_Azar
{
    internal class Producto
    {
        public int ProductoId { get; set; } // Primary key
        public string Nombre { get; set; } // Game's name
        public DateTime FechaHora { get; set; } = DateTime.Now; // Automatic creation of date/time

        // (1 - N) Relationship: A product has many numbers
        public virtual ICollection<Numero> Numeros { get; set; } = new List<Numero>();
    }

}
