using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shuffle_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            IEnumerable<int> squares = Enumerable.Range(-10, 20);
            a = squares.ToArray();
            p(a);
            shuffle(a);
            Console.WriteLine("Final a");
            p(a);
            Console.ReadKey();
        }

        static void shuffle(int []a)
        {
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                int rv = r.Next(i,a.Length);
                Console.WriteLine("Random was {0}",rv);
                swap(a,i,rv);
                p(a);
            }

            
        }
        static void swap(int[] a, int p, int q)
        {
            int t = a[p];
            a[p] = a[q];
            a[q] = t;
        }
        static void p(int []a)
        {
            foreach (var p in a)
            {
                Console.Write("{0} ",p);
            }
            Console.WriteLine();
        }

    }
    
}
