using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC184B
    {
        public static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ');
            int n = int.Parse(a[0]);
            int X = int.Parse(a[1]);
            string S = Console.ReadLine();
            long ans = X;
            for(int i = 0; i < S.Length; i++)
            {
                if(S[i] == 'o')
                {
                    ans = ans + 1;
                }
                else if(S[i] == 'x' && ans > 0)
                {
                    ans = ans - 1;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
