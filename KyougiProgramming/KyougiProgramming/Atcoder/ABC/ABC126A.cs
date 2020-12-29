using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC126A
    {
        public static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int n = int.Parse(line[0]);
            int k = int.Parse(line[1]);
            string s = Console.ReadLine();
            string ans = string.Empty;
            for(int i = 1; i <= n; i++)
            {
                if(i == k)
                {
                    ans = ans + s[i - 1].ToString().ToLower();
                }
                else
                {
                    ans = ans + s[i - 1].ToString();
                }
            }
            Console.WriteLine(ans);
        }
    }
}
