using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_INT
{
    class Program
    {   
        //HOLA MUNDO 
        //CTRL + K + C
        //CTRL + K + U
        //CREAR 3 VARIABLES TIPO INT Y ASIGNAR VALORES ESTATICOS
        //CREAR UNA VARIABLE DE TIPO INT LA CUAL GUARDARA LA SUMA DE LAS 3 VARIABLES ANTERIORES
        //MOSTRAR EN PANTALLA EL VALOR DE LA SUMA
        //CON EL SIGUIENTE MESAJE "EL VALOR DE LA SUMA ES:" <SUMA>

        static void Main(string[] args)
        {
            int numero_1 = 5;
            int numero_2 = 10;
            int numero_3 = 20;
            int suma = numero_1 + numero_2 + numero_3;
            Console.WriteLine("El valor de suma es:" + suma);
            Console.WriteLine("Preciona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
