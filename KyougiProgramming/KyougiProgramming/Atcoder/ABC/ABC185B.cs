using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC185B
    {
        public static void Main(string[] args)
        {
            string result = "Yes";
            string[] lineNMT = Console.ReadLine().Split(' ');
            int n = int.Parse(lineNMT[0]);
            int maxN = n;
            int m = int.Parse(lineNMT[1]);
            int t = int.Parse(lineNMT[2]);
            int nowTime = 0;
            for(int i = 0; i < m; i++)
            {
                string[] lineAB = Console.ReadLine().Split(' ');
                int a = int.Parse(lineAB[0]);
                int b = int.Parse(lineAB[1]);
                n = n - (a - nowTime);
                if(n <= 0)
                {
                    result = "No";
                }
                n = n + (b - a);
                n = Math.Min(maxN, n);
                nowTime = b;
                if(n <= 0)
                {
                    result = "No";
                    break;
                }
            }
            n = n - (t - nowTime);
            if (n <= 0)
            {
                result = "No";
            }
            Console.WriteLine(result);
        }
    }
}
