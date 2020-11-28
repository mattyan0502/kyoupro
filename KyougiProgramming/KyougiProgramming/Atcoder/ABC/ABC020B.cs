using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC020B
    {
        public static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            string a = str[0];
            string b = str[1];
            string ansStr = a + b;
            int ans = int.Parse(ansStr) * 2;
            Console.WriteLine(ans);
        }
    }
}
