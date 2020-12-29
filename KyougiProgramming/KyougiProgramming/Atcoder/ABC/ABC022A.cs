using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC022A
    {
        public static void Main(String[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int n = int.Parse(line[0]);
            int s = int.Parse(line[1]);
            int t = int.Parse(line[2]);
            int w = int.Parse(Console.ReadLine());
            int sum = 0;
            if (w >= s && w <= t)
            {
                sum++;
            }
            for(int i = 0; i < n - 1; i++)
            {
                int a = int.Parse(Console.ReadLine());
                w = w + a;
                if(w >= s && w <= t)
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
