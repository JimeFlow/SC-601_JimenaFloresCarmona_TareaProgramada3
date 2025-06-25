using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_Juegos_De_Azar;

namespace TP3_Juegos_De_Azar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Producto producto = new Producto();

                // 1. Name
                Console.Write("Escriba el nombre del producto: ");
                producto.Nombre = Console.ReadLine();
                producto.FechaHora = DateTime.Now;

                // 2. Total Numbers
                int cantidad;
                do
                {
                    Console.Write("Escriba la cantidad de números aleatorios a generar: ");
                } while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0);

                // 3. Can you repeat and help me with it??
                bool permitirRepetidos = true;
                if (cantidad <= 100)
                {
                    Console.Write("¿Los números se pueden repetir? (s/n): ");
                    string repetir = Console.ReadLine().Trim().ToLower();
                    permitirRepetidos = repetir == "s";
                }

                // Generate numbers
                producto.Numeros = GenerarNumerosAleatorios(cantidad, permitirRepetidos);

                // Save to database
                using (var db = new TP3Context())
                {
                    db.Productos.Add(producto);
                    db.SaveChanges();
                }

                // 4. ¿Add?
                Console.Write("¿Desea agregar otro producto? (s/n): ");
                string respuesta = Console.ReadLine().Trim().ToLower();
                continuar = respuesta == "s";
            }

            // Show everything at the end
            MostrarProductos();
            Console.WriteLine("\nPrograma finalizado. Presione la tecla ENTER para terminar.");
            Console.ReadLine();
        }

        static List<Numero> GenerarNumerosAleatorios(int cantidad, bool permitirRepetidos)
        {
            Random rand = new Random();
            HashSet<int> usados = new HashSet<int>();
            List<Numero> lista = new List<Numero>();

            for (int i = 1; i <= cantidad;)
            {
                int valor = rand.Next(0, 100); // 0 a 99

                if (permitirRepetidos || usados.Add(valor))
                {
                    lista.Add(new Numero { Orden = i, Num = valor });
                    i++;
                }
            }

            return lista;
        }

        static void MostrarProductos()
        {
            using (var db = new TP3Context())
            {
                var productos = db.Productos
                    .OrderBy(p => p.FechaHora)
                    .ToList();

                foreach (var producto in productos)
                {
                    Console.WriteLine($"\n{producto.ProductoId}. {producto.Nombre} - {producto.FechaHora}");

                    var numeros = db.Numeros
                        .Where(n => n.ProductoId == producto.ProductoId)
                        .OrderBy(n => n.Orden)
                        .ToList();

                    foreach (var numero in numeros)
                    {
                        Console.WriteLine($"{numero.NumeroId}. [{numero.Orden}] {numero.Num}");
                    }
                }
            }
        }
    }
}
