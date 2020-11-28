using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC019A
    {
        public static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int[] nums = new int[3];
            for (int i = 0; i < 3; i++)
            {
                nums[i] = int.Parse(line[i]);
            }
            Array.Sort(nums);
            int ans = nums[1];
            Console.WriteLine(ans);
        }
    }
}
