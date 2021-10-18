using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Arranque
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el numero deseado\n");
            Entero entero = new Entero(int.Parse(Console.ReadLine()));

            Console.WriteLine($"El cuadrado de {entero.getValor()} es {entero.CalcularCuadrado()}");
            Console.WriteLine($"El cubo de {entero.getValor()} es {entero.CalcularCubo()}");
            Console.ReadLine();
        }
    }
}
