using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC068B
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine(1);
            }
            else if (n < 4)
            {
                Console.WriteLine(2);
            }
            else if (n < 8)
            {
                Console.WriteLine(4);
            }
            else if (n < 16)
            {
                Console.WriteLine(8);
            }
            else if (n < 32)
            {
                Console.WriteLine(16);
            }
            else if(n < 64)
            {
                Console.WriteLine(32);
            }
            else if(n < 128)
            {
                Console.WriteLine(64);
            }
        }
    }
}
