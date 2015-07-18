using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 6,-1,3,4,5,10};
            Console.WriteLine("Max profit is {0} ",max_profit(a));
            Console.ReadKey();

        }
        static int max_profit(int [] prices)
        {
            if (prices.Length<2)
            {
                return -1;
            }

            int min_price = prices[0];
            int max_profit = prices[1]-prices[0];

            for (int i = 1; i < prices.Length; i++)
            { 
                int current_price = prices[i];
                int profit = current_price - min_price;
                max_profit = Math.Max(profit,max_profit);
                min_price = Math.Min(current_price,min_price);
            }

            return max_profit;

        }
    }
}
