using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
Escribir un pequeño programa que conste de lo siguiente: 
Una clase denominada Calculadora que posee cuatro métodos para realizar las cuatro 
operaciones básicas (sumar, restar, multiplicar y dividir). Estos métodos reciben como 
argumentos los valores con los que hay que operar que siempre serán enteros. Los valores de 
retorno de todos los métodos también serán enteros. 
Como ya se ha explicado se requiere de la definición de un punto de entrada, de la función Main. 
En ella debe instanciarse un objeto Calculadora. Después lanzar cuatro mensajes a la consola en 
los que se pueda ver un texto que represente una operación a realizar junto con el resultado, 
que se obtendrá con el método correspondiente de la clase Calculadora. Cada mensaje debe 
aparecer en una línea independiente.
*/
namespace Ejercicio_1
{
    class Program
    {
        static int valorA, valorB;
        static void Main(string[] args)
        {
            Calculadora cal = new Calculadora();

            Preguntar("sumar");
            Console.WriteLine($"Suma {valorA} con {valorB} = {cal.sumar(valorA, valorB)}");
            Console.WriteLine();
            Preguntar("restar");
            Console.WriteLine($"Resta {valorA} con {valorB} = {cal.restar(valorA, valorB)}");
            Console.WriteLine();
            Preguntar("multiplicar");
            Console.WriteLine($"Multiplicacion {valorA} con {valorB} = {cal.multiplicar(valorA, valorB)}");
            Console.WriteLine();
            Preguntar("dividir");
            Console.WriteLine($"Divicion {valorA} entre {valorB} = {cal.dividir(valorA, valorB)}");
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
