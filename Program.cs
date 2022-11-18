using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio75
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabras;
            int numero;

            ArrayList Lista = new ArrayList();
            Console.WriteLine("Ingrese la primer palabra:");
            palabras = Console.ReadLine();

            while (palabras != "salir")
            {
                Lista.Add(palabras);
                Console.WriteLine("Ingrese la proxima palabra, ingrese ¨salir¨ para salir:");
                palabras = Console.ReadLine();

            }

            Console.WriteLine("Ingrse la posicion de la palabra que desea ver:");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("en esa posicion se encentra:");

            while (numero != 0)
            {
                if (numero <= Lista.Count && numero > 0)
                {
                    numero--;
                    Console.WriteLine((string)Lista[numero]);
                    Console.WriteLine("Ingrese la posicion de la palabra que desea ver, escriba ¨0¨ para salir");

                    numero = Convert.ToInt32(Console.ReadLine());

                }
                else
                {
                    Console.WriteLine("posicion inexistente, Ingrese otra posicion o escriba ¨0¨ para salir");
                    numero = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}