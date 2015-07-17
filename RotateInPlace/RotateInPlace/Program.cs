using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateInPlace
{
    class Program
    {
        static void Main(string[] args)
        {
            rotate(3);
            
        }


        public static void rotate(int n)
        {
            int half = n / 2; 
            for (int i = 0; i < half; i++)
            {
                for (int j = i; j < n - i - 1 / 2; j++) {
                    int ni1 = n - i - 1;
                    int nj1 = n - j - 1;
                    Console.WriteLine("i j {0} {1}", i, j);
                    Console.WriteLine("i j {0} {1}",j,ni1);
                    Console.WriteLine("i j {0} {1}",ni1,nj1);
                    Console.WriteLine("i j {0} {1}",nj1,i);


                }
            }

        }
    }
}
