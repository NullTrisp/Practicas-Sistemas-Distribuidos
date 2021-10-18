using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalC
{
    public static class Calculator
    {
        private static void sanitizeStrings(string a, string b)
        {
            if (a[a.Length - 1].Equals('-') || b[b.Length - 1].Equals('-'))
            {
                throw new Exception();
            }
        }
        public static string Sum(string a, string b)
        {
            sanitizeStrings(a, b);
            return (Convert.ToDecimal(a) + Convert.ToDecimal(b)).ToString("0.0000");
        }

        public static string Subs(string a, string b)
        {
            sanitizeStrings(a, b);
            return (Convert.ToDecimal(a) - Convert.ToDecimal(b)).ToString("0.0000");
        }

        public static string Div(string a, string b)
        {
            sanitizeStrings(a, b);
            return (Convert.ToDecimal(a) / Convert.ToDecimal(b)).ToString("0.0000");
        }

        public static string Mult(string a, string b)
        {
            sanitizeStrings(a, b);
            return (Convert.ToDecimal(a) * Convert.ToDecimal(b)).ToString("0.0000");
        }

        public static string Percentage(string a, string b)
        {
            return ((Convert.ToDecimal(b) * Convert.ToDecimal(a)) / 100).ToString("0.0000");
        }

        public static string DivideByX(string a)
        {
            return (1 / Convert.ToDecimal(a)).ToString("0.0000");
        }

        public static string sqrRoot(string a)
        {
            return (Math.Sqrt(Convert.ToDouble(a))).ToString("0.0000");
        }

        public static string Pow(string a)
        {
            return (Math.Pow(Convert.ToDouble(a), 2)).ToString("0.0000");
        }
    }
}
