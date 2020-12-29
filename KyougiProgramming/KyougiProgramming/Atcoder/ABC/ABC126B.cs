using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC126B
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int y = n / 100;
            int m = n % 100;
            string ans = string.Empty;
            if(1 <= y && y <= 12)
            {
                if(1 <= m && m <= 12)
                {
                    ans = "AMBIGUOUS";
                }
                else
                {
                    ans = "MMYY";
                }
            }
            else
            {
                if(1 <= m && m <= 12)
                {
                    ans = "YYMM";
                }
                else
                {
                    ans = "NA";
                }
            }
            Console.WriteLine(ans);
            
        }
    }
}
