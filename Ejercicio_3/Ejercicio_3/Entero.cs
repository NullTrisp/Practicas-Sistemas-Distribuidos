using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Entero
    {
        private int valor;

        public Entero(int valor)
        {
            this.valor = valor;
        }

        public int getValor()
        {
            return this.valor;
        }

        public double CalcularCuadrado()
        {
            return Math.Pow(this.valor, 2);
        }

        public double CalcularCubo()
        {
            return Math.Pow(this.valor, 3);
        }
    }
}
