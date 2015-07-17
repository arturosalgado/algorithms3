using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a = { -5, 0, -4, 1, 4, 3, -2, -1, 2, -3 };
            int[] a = { -5, 0, -4, 1};
            //IEnumerable<int> squares = Enumerable.Range(1, 4);
            //a = squares.ToArray();
            //p(a);
            //shuffle(a);
            p(a);

            dumb(a);
            p(a);
            Console.ReadKey();


        }

        static void dumb(int []a )
        {
            int max = 0; 

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i; j < a.Length; j++)
                {
                    int s = 0; 
                    //Console.WriteLine("i = {0} j = {1}",i,j);
                    for (int p = i; p <= j; p++ )
                    {
                            s += a[p];
                            Console.Write("{0} {1} {2} ",i,j,p);
                            Console.WriteLine();
                    }
                    max = Math.Max(max, s);
                }
            }

            Console.WriteLine(max);
        }

        static void shuffle(int[] a)
        {
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                int rv = r.Next(-10,20);
                //Console.WriteLine("Random was {0}", rv);
                a[i] = rv;
                //p(a);
            }


        }
        static void swap(int[] a, int p, int q)
        {
            int t = a[p];
            a[p] = a[q];
            a[q] = t;
        }
        static void p(int[] a)
        {
            foreach (var p in a)
            {
                Console.Write("{0} ", p);
            }
            Console.WriteLine();
        }


    }
}
