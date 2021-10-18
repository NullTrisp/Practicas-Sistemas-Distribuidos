using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Varios
    {
        private static readonly int LIMIT = 30;

        private static void IteratePrimes(bool prime)
        {
            for (int i = 1; i <= LIMIT; ++i)
            {
                bool isPrime = true;
                for (int j = 2; j < i || i == 1; ++j)
                {
                    if (i % j == 0 || i == 1)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime && prime)
                {
                    Console.WriteLine($"{i} es un numero primo");
                }
                else if (!isPrime && !prime)
                {
                    Console.WriteLine($"{i} no es un numero primo");
                }
            }
        }
        public static void MostrarNoPrimos()
        {
            IteratePrimes(false);
        }
        public static void MostrarPrimos()
        {
            IteratePrimes(true);
        }
    }

}
