using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Juegos_De_Azar
{
    internal class Numero
    {
        public int NumeroId { get; set; } // Primary key
        public int Orden { get; set; } // Position of the generated number
        public int Num { get; set; } // Random number value between 0 and 99
 
        public int ProductoId { get; set; } // Foreign key to the product
        public virtual Producto Producto { get; set; } // Inverse relationship to the product

    }
}
