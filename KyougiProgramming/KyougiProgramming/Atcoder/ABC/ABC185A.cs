using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC185A
    {
        public static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int[] nums = new int[4];
            int i = 0;
            int min = 10000;
            foreach(string str in line)
            {
                nums[i] = int.Parse(line[i]);
                min = Math.Min(min, nums[i]);
                i++;
            }
            Console.WriteLine(min);
        }
    }
}
