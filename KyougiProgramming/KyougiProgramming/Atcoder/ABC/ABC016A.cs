using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC016A
    {
        public static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int M = int.Parse(str[0]);
            int D = int.Parse(str[1]);
            string result = "NO";
            if(M % D == 0)
            {
                result = "YES";
            }
            Console.WriteLine(result);
        }
    }
}
