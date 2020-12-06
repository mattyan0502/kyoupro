using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC139B
    {
        public static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int a = int.Parse(line[0]);
            int b = int.Parse(line[1]);
            int count = 1;
            int ans = 0;
            while(count < b)
            {
                count--;
                count = count + a;
                ans++;
            }
            Console.WriteLine(ans);
        }
    }
}
