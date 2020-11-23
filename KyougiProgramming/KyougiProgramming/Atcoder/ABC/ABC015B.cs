using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC015B
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split(' ');
            int sum = 0;
            int count = 0;
            for(int i = 0; i < n; i++)
            {
                int a = int.Parse(str[i]);
                sum = sum + a;
                count++;
                if(a == 0)
                {
                    count = count - 1;
                }
            }
            int ans;
            int shou = sum / count;
            int amari = sum % count;
            if(amari == 0)
            {
                ans = shou;
            }
            else
            {
                ans = shou + 1;
            }
            Console.WriteLine(ans);
        }
    }
}
