using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_5
{
    class Operacion
    {
        protected int operando;

        public Operacion(int operando)
        {
            this.operando = operando;
        }

        public virtual int Calcular()
        {
            return 0;
        }
    }
}
