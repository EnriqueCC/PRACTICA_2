using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_string
{
    class Program

        //pedir por consola el nombre de la persona
        //y el nombre de una ciudadd y mostrar en la pantalla
        //"hola + nombre + bienvenido a +ciudad"

    {
        static void Main(string[] args)
        {
            string nombre, ciudad;
            Console.WriteLine("Escribe tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Escribe una ciudad");
            ciudad = Console.ReadLine();
            Console.WriteLine(" Hola " + nombre + " Bienvenido a " + ciudad);
            Console.WriteLine("Preciona cualquier tecla para continuar");
            Console.ReadKey();

        }
    }
}
