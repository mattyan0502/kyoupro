using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC086B
    {
        public static void Main(string[] ars)
        {
            string str = Console.ReadLine();
            str = str.Replace(" ","");
            int n = int.Parse(str);
            decimal num = (decimal)Math.Sqrt(n);
            string result = "No";
            if(num % 1 == 0)
            {
                result = "Yes";
            }
            Console.WriteLine(result);
        }
    }
}
