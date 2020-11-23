using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC016B
    {
        public static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int A = int.Parse(str[0]);
            int B = int.Parse(str[1]);
            int C = int.Parse(str[2]);
            string result = "!";
            bool tasu = A + B == C;
            bool hiku = A - B == C;
            if(tasu && hiku)
            {
                result = "?";
            }
            else if(tasu && !hiku)
            {
                result = "+";
            }
            else if(!tasu && hiku)
            {
                result = "-";
            }
            Console.WriteLine(result);
        }
    }
}
