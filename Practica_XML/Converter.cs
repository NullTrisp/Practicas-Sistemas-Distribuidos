using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_XML
{
    class Converter
    {
        public static readonly string EuroToDolar = "EUR-DOLLAR";
        public static readonly string DolarToEuro = "DOLLAR-EUR";
        public static readonly string Euro = "eur";
        public static readonly string Dollar = "dollar";

        public static string ToDollar(decimal value)
        {
            return Convert.ToString(value * 1.16m);
        }

        public static string ToEur(decimal value)
        {
            return Convert.ToString(value * 0.86m);
        }
    }
}
