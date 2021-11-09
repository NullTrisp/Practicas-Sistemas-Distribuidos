using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyServer
{
    class Converter
    {
        public static readonly string Euro = "euro";
        public static readonly string Dollar = "dollar";
        public static decimal ToDollar(decimal value)
        {
            return value * 1.16m;
        }

        public static decimal ToEur(decimal value)
        {
            return value * 0.86m;
        }
    }
}
