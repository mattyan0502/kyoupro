using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming
{
    class ABC015A
    {
        public static void Main(string[] args)
        {
            string al = Console.ReadLine();
            string bl = Console.ReadLine();
            Console.WriteLine(al.Length > bl.Length ? al : bl);
        }
    }
}
