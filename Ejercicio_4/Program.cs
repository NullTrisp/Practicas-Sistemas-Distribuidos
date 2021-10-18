using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Construir una nueva clase cuyo nombre será Varios. Dotar a esta clase de dos métodos estáticos
y públicos. Se llamarán MostrarPrimos y MostrarNoPrimos, su cometido será, respectivamente,
mostrar en la consola los números primos entre los 30 primeros números enteros y los números
no primos en el mismo rango.

El programa comenzará lanzando un mensaje que informe al usuario de que debe pulsar una
letra para realizar cada operación posible y otra para abandonar el programa. Si el usuario no
introduce los caracteres esperados se lanzará un mensaje apropiado.
Cada uno de los métodos mostrará un mensaje como “El número n es primo”. Cada mensaje
debe ir en una línea independiente para que sea legible.

El programa se mantendrá en ejecución indefinidamente con la pregunta inicial, hasta que el
usuario suspenda la ejecución pulsando el carácter de finalización.
 */
namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            Console.WriteLine("Bienvenido usuario");
            while (!salir)
            {
                Console.ResetColor();
                Console.WriteLine("Para el programa hay las siguientes opciones\n");
                Console.WriteLine("[p] => Mostrar primos");
                Console.WriteLine("[n] => Mostrar no primos");
                Console.WriteLine("[x] => Salir");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "p":
                        Varios.MostrarPrimos();
                        break;
                    case "n":
                        Varios.MostrarNoPrimos();
                        break;
                    case "x":
                        salir = !salir;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Seleccione una opcion valida!\n\n\n");
                        break;
                }
            }
        }
    }
}

