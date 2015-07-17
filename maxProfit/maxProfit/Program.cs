using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stocks = { -1,5,-1,4};
            Console.WriteLine(Stocks(stocks));
            Console.ReadKey();
        }

        static int Stocks(int []a )
        {
            int[] deltas = new int[a.Length];
            for (int i = 1; i < deltas.Length; i++) {
                deltas[i] = a[i] - a[i - 1];
            }

            int best = max(deltas);
            return best;
        }
        static int max(int []a)
        {
            int local_max = 0;
            int global_max = 0;

            for (int i = 0; i < a.Length; i++)
            {
                local_max = Math.Max(local_max+a[i],0);
                global_max = Math.Max(global_max , local_max);
    
            }
            return global_max;
        }
    }
}
