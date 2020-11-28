using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC017B
    {
        public static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string result = "NO";
            x = x.Replace("ch", "");
            x = x.Replace("o", "");
            x = x.Replace("k", "");
            x = x.Replace("u", "");
            if(x.Length == 0)
            {
                result = "YES";
            }
            Console.WriteLine(result);
        }
    }
}
