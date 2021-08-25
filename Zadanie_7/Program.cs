using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int rok = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(wielkanoc(rok));

            }

        }
        
        private static String wielkanoc(int year)
        {
            double calc;

            int a = year % 19;

            calc = year / 100;
            int b = (int)Math.Floor(calc);

            int c = year % 100;

            calc = b / 4;
            int d = (int)Math.Floor(calc);

            int e = b % 4;

            calc = (b + 8) / 25;
            int f = (int)Math.Floor(calc);

            calc = (b - f + 1) / 3;
            int g = (int)Math.Floor(calc);

            int h = (19 * a + b - d - g + 15) % 30;

            calc = c / 4;
            int i = (int)Math.Floor(calc);

            int k = c % 4;

            int l = (32 + 2 * e + 2 * i - h - k) % 7;

            calc = (a + 11 * h + 22 * l) / 451;
            int m = (int)Math.Floor(calc);

            int p = (h + l - 7 * m + 114) % 31;

            int day = p + 1;

            calc = (h + l - 7 * m + 114) / 31;
            int month = (int)Math.Floor(calc);

            return string.Format("{0}-{1}-{2}", year, month, day);
        }
    }
}
