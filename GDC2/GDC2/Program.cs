using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDC2
{
    class Program
    {
        static void Main(string[] args)
        {
          long t =   expo(7,3);
          Console.WriteLine(t);
          Console.ReadKey();
        }
        static long expo(long b, long exp)
        {
            
            List<long> powers = new List<long>();
            List<long> values = new List<long>();

            long  value = b;
            long  power = 1;


            powers.Add(power);
            values.Add(value);
            while (power < exp )
            {
                power = power * 2;
                value = value * value;
                powers.Add(power);
                values.Add(value);
                
            }

            int count = powers.Count - 1;
            long result = 1; 
            for (int p = count; p >= 0; p--)
            {
                if (powers[p] <= exp) { 
                    exp -= powers[p];
                    result = (result * values[p]);
                }
            }
            return result;
        }
    }
}
