using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int []a = {6,10,14,15,500,8};
            shift(a);
            shift2(a);

        }
        static void shift(int []a )
        {
            int j =  a.Length-1;
            int element = a[j];
            
                j = a.Length-1;
                while (j > 0 && element<a[j-1] )
                {
                    a[j ] = a[j-1];
                    j--;
                    a[j] = element;
                  
                }
            
        }

        static void shift2(int[] a)
        {
            int j = a.Length - 1;

            for (int i = 1; i < a.Length; i++) {

                j = i;
                int element = a[j];

              
                while (j > 0 && element < a[j - 1])
                {
                    a[j] = a[j - 1];
                    j--;
                    a[j] = element;

                }
            }

        }

    }
}
