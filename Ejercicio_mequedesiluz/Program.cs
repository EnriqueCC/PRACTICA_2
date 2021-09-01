using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_mequedesiluz
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, edad;
            Console.WriteLine("Escribe tu nombre ");
            nombre = Console.ReadLine();
            Console.WriteLine("Escribe tu edad ");
            edad = Console.ReadLine();
            Console.WriteLine(" Tu nombre es  " + nombre + " y tienes " + edad);
            Console.WriteLine("Preciona cualquier tecla para continuar");
            Console.ReadKey();

        }
    }
}
