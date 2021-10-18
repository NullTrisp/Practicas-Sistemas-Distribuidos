using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_5
{
    class Cubo : Operacion
    {
        public Cubo(int operando) : base(operando)
        {
        }
        public override int Calcular()
        {
            return Convert.ToInt32(Math.Pow(this.operando, 3));
        }
    }
}
