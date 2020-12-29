using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC024A
    {
        public static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine().Split(' ');
            string[] line2 = Console.ReadLine().Split(' ');
            int a = int.Parse(line1[0]);
            int b = int.Parse(line1[1]);
            int c = int.Parse(line1[2]);
            int k = int.Parse(line1[3]);
            int s = int.Parse(line2[0]);
            int t = int.Parse(line2[1]);
            int kodomo = a * s;
            int otona = b * t;
            int nin = s + t;
            int hiku = 0;
            if(nin >= k)
            {
                hiku = nin * c;
            }
            int ans = otona + kodomo - hiku;
            Console.WriteLine(ans);
        }
    }
}
