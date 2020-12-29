using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC074B
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');
            int[] x = new int[n];
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                x[i] = int.Parse(line[i]);
                int a2 = x[i] * 2;
                int b2 = (k - x[i]) * 2;
                sum = sum + Math.Min(a2, b2);
            }
            Console.WriteLine(sum);
        }
    }
}
