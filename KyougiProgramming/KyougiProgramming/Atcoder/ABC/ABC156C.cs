using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC156C
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');
            int[] x = new int[n];
            int i = 0;
            int sum = 0;
            foreach(string str in line)
            {
                x[i] = int.Parse(str);
                sum = sum + x[i];
                i++;
            }
            int ans = 0;
            int min = int.MaxValue;
            for(int j = 0; j <= 100; j++)
            {
                foreach(int num in x)
                {
                    ans += (num - j) * (num - j);
                }
                min = Math.Min(min, ans);
                ans = 0;
            }
            Console.WriteLine(min);
        }
    }
}
