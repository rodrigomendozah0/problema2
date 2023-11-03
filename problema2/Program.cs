using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = pantallas.MenuPrincipal();

            do
            {
                Console.Clear();
                switch (opcion)
                {

                    case 1:
                        Console.Clear();
                        opcion = pantallas.IngresarNota();
                        break;
                    case 2:
                        Console.Clear();
                        opcion = pantallas.NotaAlta();
                        break;
                    case 3:
                        Console.Clear();
                        opcion = pantallas.NotaBaja();
                        break;
                    case 4:
                        Console.Clear();
                        opcion = pantallas.ListaNotas();
                        break;
                    case 0:
                    default:
                        opcion = pantallas.MenuPrincipal();
                        break;

                }
            } while (opcion != 5);
            Console.ReadKey();
        }
    }
}
