using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.Other
{
    class Tax_Rate
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int wari = n * 8 / 100;
            int mae = n - wari;
            int ans = 0;
            if(wari == 0)
            {
                ans = n;
            }
            else
            {
                for(int i = mae; i <= n; i++)
                {
                    int num = (int)(i * 1.08);
                    if(num == n)
                    {
                        ans = i;
                        break;
                    }
                }
            }
            if(ans == 0)
            {
                Console.WriteLine(":(");
            }
            else
            {
                Console.WriteLine(ans);
            }
        }
    }
}
