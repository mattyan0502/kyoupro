using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.PAST
{
    class P4_B
    {
        public static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int x = int.Parse(line[0]);
            int y = int.Parse(line[1]);
            if (y == 0)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                int shou = x / y;
                int amari = (x * 100 / y) % 100;
                string ans = string.Format("{0}.{0:D2}",shou.ToString(),amari.ToString());
            }
        }
    }
}
