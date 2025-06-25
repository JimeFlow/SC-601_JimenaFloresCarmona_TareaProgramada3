using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TP3_Juegos_De_Azar; //

namespace TP3_Juegos_De_Azar
{
    internal class TP3Context : DbContext
    {
        // Constructor that invokes the "TP3" connection string
        public TP3Context() : base("TP3") { }

        // DbSets represent the tables in the database
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Numero> Numeros { get; set; }
    }
}
