using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC185C
    {
        public static void Main(string[] args)
        {
            ulong l = ulong.Parse(Console.ReadLine());
            ulong ue = 1;
            ulong sita = 1;
            ulong ans = 0;
            if (l == 12)
            {
                ans = 1;
            }
            else
            {
                ulong a = l - 12;
                for(ulong i = 0; i < a; i++)
                {
                    ue = ue * (l - 1 - i);
                    sita = sita * (i + 1);
                    if(ue % sita == 0)
                    {
                        ue = ue / sita;
                        sita = 1;
                    }
                }
                ans = ue;
                if(l % 12 == 0) ans = ans + 1;
            }
            Console.WriteLine(ans);
        }
    }
}
