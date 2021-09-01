using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULOPERIMETRO
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor_a = 10;
            int valor_b = 10;
            int valor_c = 7;
            int perimetro = valor_a + valor_b + valor_c;
            Console.WriteLine("El perimetro del triangulo es:" + perimetro);
            Console.WriteLine("Preciona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
