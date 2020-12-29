using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC088B
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');
            int[] a = new int[n];
            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(line[i]);
            }
            Array.Sort(a);
            int[] maxa = new int[n];
            int k = 0;
            for(int j = n - 1; j >= 0; j--)
            {
                maxa[k] = a[j];
                k = k + 1;
            }
            int suma = 0;
            int sumb = 0;
            for(int b = 0; b < n; b++)
            {
                if(b % 2 == 0)
                {
                    suma = suma + maxa[b];
                }
                else
                {
                    sumb = sumb + maxa[b];
                }
            }
            int ans = suma - sumb;
            Console.WriteLine(ans);
        }
    }
}
