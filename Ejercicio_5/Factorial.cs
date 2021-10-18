using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_5
{
    class Factorial : Operacion
    {
        public Factorial(int operando) : base(operando)
        {
        }
        public override int Calcular()
        {
            int n = 1;
            for (int i = n; i <= this.operando; ++i)
            {
                n *= i;
            }

            return n;
        }
    }
}
