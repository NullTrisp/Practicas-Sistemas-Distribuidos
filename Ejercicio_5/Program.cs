using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones();
            for (int i = 1; i <= 15; ++i)
            {
                Console.WriteLine(i % 3);
                if (i % 3 == 0)
                {
                    operaciones.AñadirOperacion(new Cuadrado(i), i - 1);
                }
                else if (i % 3 == 2)
                {
                    operaciones.AñadirOperacion(new Factorial(i), i - 1);
                }
                else if (i % 3 == 1)
                {
                    operaciones.AñadirOperacion(new Cubo(i), i - 1);
                }
            }

            operaciones.MostrarResultados();

            System.Security.Cryptography.MD5();
        }
    }
}
