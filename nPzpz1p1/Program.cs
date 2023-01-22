using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nPzpz1p1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n1 = new int[10], n2 = new int[10];
            int ni1 = 0, ni2 = 0,n=0;
            do
            {
                Console.Write("Unesite brojeve: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n == 0) { }
                else if (n % 2 == 0)
                {
                    n2[ni2++] = n;
                }
                else
                {
                    n1[ni1++] = n;
                }
            } while (n!=0 && ni1 < 10 && ni2 < 10);
            Console.WriteLine();
            for (int i = 0; i<ni1; i++)
            {
                Console.Write(n1[i] + ",");
            }
            Console.WriteLine();
            for (int i = 0; i < ni2; i++)
            {
                Console.Write(n2[i] + ",");
            }
            Console.ReadKey();
        }
    }
}
