using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC023B
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string ans = "b";
            int sum = 0;
            bool flag = false;
            if(ans == s)
            {
                Console.WriteLine(0);
                return;
            }
            for(int i = 0; i < n; i++)
            {
                //1
                ans = "a" + ans + "c";
                sum = sum + 1;
                if(s == ans)
                {
                    flag = true;
                    break;
                }
                //2
                ans = "c" + ans + "a";
                sum = sum + 1;
                if (s == ans)
                {
                    flag = true;
                    break;
                }
                //3
                ans = "b" + ans + "b";
                sum = sum + 1;
                if (s == ans)
                {
                    flag = true;
                    break;
                }
            }
            if(flag == false)
            {
                sum = -1;
            }
            Console.WriteLine(sum);
        }
    }
}
