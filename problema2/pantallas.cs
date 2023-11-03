using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema2
{
    internal class pantallas
    {
        public static string[] nombresalumnos = new string[100];
        public static float[] notas = new float[100];
        public static float[] estudiantestotales = new float[100];
        public static int contador = 0;

        public static int MenuPrincipal()
        {
            string texto = "================================\n" +
                "Nota de estudiantes\n" +
                "================================\n" +
                "1: Ingresar notas\n" +
                "2: Nota más alta\n" +
                "3: Nota más baja\n" +
                "4: Ver lista de Estudiantes\n";
            Console.Write(texto);

            return Operaciones.getEntero("Ingresa una opcion:", texto);
        }

        public static int IngresarNota()
        {
            string texto1 = "================================\n" +
            "Ingresar Nota\n" +
            "================================\n";
            Console.WriteLine(texto1);
            string nombre = Operaciones.getTextoPantalla("Ingrese el nombre: ");
            float notaRegistrar = Operaciones.getDecimal("Ingrese la nota: ");

            if (contador == 100)
            {
                Console.WriteLine("La lista está llena");
            }
            nombresalumnos[contador] = nombre;
            notas[contador] = notaRegistrar;
            contador++;

            string texto = "================================\n" +
             "!Guardado!\n" +
               "================================\n";

            Console.WriteLine("1: Agregar uno más | 2: Volver");
            int opcion = Operaciones.getEntero("Ingresa una opción: ", texto);

            if (opcion == 2) return 0;

            return opcion;
        }
        public static int NotaAlta()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Nota más alta");
            Console.WriteLine("================================");

            if (contador == 0)
            {
                Console.WriteLine("No existen notas todavía");
            }
            else
            {
                float mayor = notas[0];
                int posicioMayor = 0;
                for (int i = 0; i < contador; i++)
                {
                    if (notas[i] > mayor)
                    {
                        mayor = notas[i];
                        posicioMayor = i;
                    }
                }

                Console.WriteLine("Estudiante: " + nombresalumnos[posicioMayor]); // Muestra el nombre del estudiante
                Console.WriteLine("Nota: " + mayor);

                for (int i = 0; i < contador; i++)
                {
                    if (i == posicioMayor)
                    {
                        Console.Write("[" + notas[i] + "] ");
                    }
                    else
                    {
                        Console.Write(notas[i] + " ");
                    }
                }

                Console.WriteLine("\n================================");

            }

            Console.WriteLine("Presione Enter para volver");
            Console.WriteLine("================================");

            Console.ReadLine();

            return 0;
        }
        public static int NotaBaja()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Nota más baja");
            Console.WriteLine("================================");

            if (contador == 0)
            {
                Console.WriteLine("No existen notas todavía");
            }
            else
            {
                float menor = notas[0];
                int posicioMenor = 0;
                for (int i = 0; i < contador; i++)
                {
                    if (notas[i] < menor)
                    {
                        menor = notas[i];
                        posicioMenor = i;
                    }
                }

                Console.WriteLine("Estudiante: " + nombresalumnos[posicioMenor]);
                Console.WriteLine("Nota: " + menor);

                for (int i = 0; i < contador; i++)
                {
                    if (i == posicioMenor)
                    {
                        Console.Write("[" + notas[i] + "] ");
                    }
                    else
                    {
                        Console.Write(notas[i] + " ");
                    }
                }

                Console.WriteLine("\n================================");
            }

            Console.WriteLine("Presione Enter para volver");
            Console.WriteLine("================================");

            Console.ReadLine();

            return 0;
        }

        public static int ListaNotas()
        {
            string texto1 = "================================\n" +
             "Lista de estudiantes\n" +
             "================================\n";
            Console.WriteLine(texto1);
            if (contador == 0)
            {
                Console.WriteLine("No existen notas todavía");
            }
            else
            {
                for (int i = 0; i < contador; i++)
                {
                    Console.WriteLine("Nombre: " + nombresalumnos[i] + "\tNota: " + notas[i]);
                }
            }

            Console.WriteLine("================================");
            Console.WriteLine("Presione Enter para volver");
            Console.WriteLine("================================");

            Console.ReadLine();

            return 0;
        }
    }
}
