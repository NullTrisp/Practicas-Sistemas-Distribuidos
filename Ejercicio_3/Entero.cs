using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Entero
    {
        int value;

        public Entero(int value)
        {
            this.value = value;
        }

        public double CalcularCuadrado()
        {
            return Math.Pow((double)this.value, (double)2);
        }
    }
}
