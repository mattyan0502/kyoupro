using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.Other
{
    class pana2020B
    {
        public static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            long h = long.Parse(line[0]);
            long w = long.Parse(line[1]);
            long[,] a = new long[h, w];
            long min = 1000;
            for(long i = 0; i < h; i++)
            {
                string[] aLine = Console.ReadLine().Split(' ');
                for(long j = 0; j < w; j++)
                {
                    a[i, j] = long.Parse(aLine[j]);
                    if(min > a[i,j])
                    {
                        min = a[i, j];
                    }
                }
            }
            long ans = 0;
            for(long k = 0; k < h; k++)
            {
                for(long l = 0; l < w; l++)
                {
                    ans = ans + a[k, l] - min;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
