using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC121B
    {
        public static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int n = int.Parse(line[0]);
            int m = int.Parse(line[1]);
            int c = int.Parse(line[2]);
            int[] b = new int[m];
            string[] bline = Console.ReadLine().Split(' ');
            int i = 0;
            foreach(string str in bline)
            {
                b[i] = int.Parse(str);
                i = i + 1;
            }
            int[,] a = new int[n,m];
            for(int j = 0; j < n; j++)
            {
                string[] line2 = Console.ReadLine().Split(' ');
                for(int k = 0; k < m; k++)
                {
                    a[j,k] = int.Parse(line2[k]);
                }
            }

            int sum = 0;
            int ans = 0;
            for(int q = 0; q < n; q++)
            {
                ans = 0;
                for(int p = 0; p < m; p++)
                {
                    ans = ans + a[q, p] * b[p];
                }
                if(ans + c > 0 )
                {
                    sum = sum + 1;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
