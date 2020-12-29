using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC023A
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int sum = 0;
            foreach(char ch in str)
            {
                sum = sum + int.Parse(ch.ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
