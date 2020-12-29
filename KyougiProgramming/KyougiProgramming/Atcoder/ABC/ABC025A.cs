using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC025A
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int[] num = new int[] {11,12,13,14,15,21,22,23,24,25,31,32,33,34,35,41,42,43,44,45,51,52,53,54,55};
            int n = int.Parse(Console.ReadLine());
            int a = num[n - 1] / 10;
            int b = num[n - 1] % 10;
            string ans = s[a - 1].ToString() + s[b - 1].ToString() + "";
            Console.WriteLine(ans);

        }
    }
}
