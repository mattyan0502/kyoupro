using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.PAST
{
    class P4_A
    {
        public static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int[] nums = new int[3];
            nums[0] = int.Parse(line[0]);
            nums[1] = int.Parse(line[1]);
            nums[2] = int.Parse(line[2]);
            int max = 0;
            int smax = 0;
            for(int i = 0; i < 3; i++)
            {
                if(max <= nums[i])
                {
                    smax = max;
                    max = nums[i];
                }
                else if(smax < nums[i])
                {
                    smax = nums[i];
                }
            }
            string ans = "A";
            if(smax == nums[1])
            {
                ans = "B";
            }
            else if(smax == nums[2])
            {
                ans = "C";
            }
            Console.WriteLine(ans);
        }
    }
}
