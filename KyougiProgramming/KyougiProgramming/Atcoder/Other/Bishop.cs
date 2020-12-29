using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.Other
{
    class Bishop
    {
        public static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            ulong h = ulong.Parse(line[0]);
            ulong w = ulong.Parse(line[1]);
            ulong ans = 0;
            if(h == 1 || w == 1)
            {
                ans = 1;
            }
            else if(h % 2 == 1 && w % 2 ==1)
            {
                ans = h * w / 2 + 1;
            }
            else
            {
                ans = h * w / 2;
            }
            Console.WriteLine(ans);
        }
    }
}
