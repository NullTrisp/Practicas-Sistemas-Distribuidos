using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static int valorA, valorB;
        static void Main(string[] args)
        {
            Preguntar("sumar");
            Console.WriteLine($"Suma {valorA} con {valorB} = {Calculadora.sumar(valorA, valorB)}");
            Console.WriteLine();
            Preguntar("restar");
            Console.WriteLine($"Resta {valorA} con {valorB} = {Calculadora.restar(valorA, valorB)}");
            Console.WriteLine();
            Preguntar("multiplicar");
            Console.WriteLine($"Multiplicacion {valorA} con {valorB} = {Calculadora.multiplicar(valorA, valorB)}");
            Console.WriteLine();
            Preguntar("dividir");
            Console.WriteLine($"Divicion {valorA} entre {valorB} = {Calculadora.dividir(valorA, valorB)}");
            Console.ReadLine();
        }

        static void Preguntar(string prefijo)
        {
            Console.WriteLine($"Inserta el primer valor para {prefijo}: ");
            valorA = int.Parse(Console.ReadLine());
            Console.WriteLine($"Inserta el segundo valor: {prefijo}");
            valorB = int.Parse(Console.ReadLine());
        }
    }
}
