using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.Other
{
    class pana2020A
    {
        public static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int n = int.Parse(line[0]);
            int m = int.Parse(line[1]);
            int ans = n / m;
            Console.WriteLine(ans);
        }
    }
}
