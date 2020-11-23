using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC017A
    {
        public static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine().Split(' ');
            string[] line2 = Console.ReadLine().Split(' ');
            string[] line3 = Console.ReadLine().Split(' ');
            int s1 = int.Parse(line1[0]);
            int e1 = int.Parse(line1[1]);
            int s2 = int.Parse(line2[0]);
            int e2 = int.Parse(line2[1]);
            int s3 = int.Parse(line3[0]);
            int e3 = int.Parse(line3[1]);

            int mut1 = s1 * e1 / 10;
            int mut2 = s2 * e2 / 10;
            int mut3 = s3 * e3 / 10;
            int ans = mut1 + mut2 + mut3;
            Console.WriteLine(ans);

        }
    }
}
