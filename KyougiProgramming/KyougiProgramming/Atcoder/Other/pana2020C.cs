using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.Other
{
    class pana2020C
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int ans = 0;
            for(int i = 1; i <= n; i++)
            {
                if (i.ToString().Contains('7') == false)
                {
                    if(Convert.ToString(i,8).Contains('7') == false)
                    {
                        ans++;
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}
