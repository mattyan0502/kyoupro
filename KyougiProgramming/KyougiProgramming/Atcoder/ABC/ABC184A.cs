using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC184A
    {
        public static void Main(string[]args)
        {
            string[] str1 = Console.ReadLine().Split(' ');
            string[] str2 = Console.ReadLine().Split(' ');
            int a = int.Parse(str1[0]);
            int b = int.Parse(str1[1]);
            int c = int.Parse(str2[0]);
            int d = int.Parse(str2[1]);

            int ans = a * d - b * c;
            Console.WriteLine(ans);

        }
    }
}
