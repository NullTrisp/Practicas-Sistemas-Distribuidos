using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_5
{
    class Operaciones
    {
        private Operacion[] operaciones = new Operacion[15];

        public void AñadirOperacion(Operacion operacion, int posicion)
        {
            this.operaciones[posicion] = operacion;
        }

        public void MostrarResultados()
        {
            foreach (Operacion operacion in operaciones)
            {
                if (operacion != null)
                {
                    Console.WriteLine($"Clase {operacion.GetType()}, resultado {operacion.Calcular()}");
                }
            }
        }
    }
}
