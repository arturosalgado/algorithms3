using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exponent
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine(Exponentiate(7, 3));
            Console.WriteLine();
            //Console.WriteLine(exp2(7,3));
            Console.ReadKey();
        }
        static long exp2(long value , long exponent)
        {

            long temp = 1;
            for (int i = 0; i < exponent; i++)
            {
                temp = temp * value;
            }
                return temp; 
        }
        static long Exponentiate(long value, long exponent)
        {
            // Make lists of powers and the value to that power.
            List<long> powers = new List<long>();
            List<long> valueToPowers = new List<long>();

            // Start with the power 1 and value^1.
            long lastPower = 1;
            long lastValue = value;
            powers.Add(lastPower);
            valueToPowers.Add(lastValue);

            // Calculate other powers until we get to one bigger than exponent.
            while (lastPower < exponent)
            {
                lastPower *= 2;
                lastValue *= lastValue;
                powers.Add(lastPower);
                valueToPowers.Add(lastValue);
            }

            // Combine values to make the required power.
            long result = 1;

            // Get the index of the largest power that is smaller than exponent.
            for (int powerIndex = powers.Count - 1; powerIndex >= 0; powerIndex--)
            {
                // See if this power fits within exponent.
                if (powers[powerIndex] <= exponent)
                {
                    // It fits. Use this power.
                    exponent -= powers[powerIndex];
                    result *= valueToPowers[powerIndex];
                }
            }

            // Return the result.
            return result;
        }

    }
}
