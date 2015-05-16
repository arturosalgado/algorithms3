using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(gcd(24,9));
            Console.WriteLine();
            Console.Write(gdc_loop(24, 7));

            Console.ReadKey();

        }
        /* recursive gcd */
        static int gcd(int a , int b)
        {
            if (b == 0)
            {
                return a;
            }
            else {
                int c = a % b;
                return gcd(b,c);
            }
        }

        static int gdc_loop(int a, int b) {

            while (b != a)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
               
            }
            return b;
        }

       


    }
}
