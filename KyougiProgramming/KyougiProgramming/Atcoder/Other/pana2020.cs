using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.Other
{
    class pana2020
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');
            int[] a = new int[n];
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(line[i]);
                sum = sum + i;
            }

            int sum2 = a[0];
            int ans = 0;
            int anss = 0;
            for(int j = 0; j < n - 1;j++)
            {
                ans = ans + a[j] * 2 - sum - sum2;
                if(ans < 0)
                {
                    ans = ans * (-1);
                }
                anss = anss + ans;
                sum2 = sum2 + a[j + 1];
            }
            Console.WriteLine(anss);
        }
    }
}
