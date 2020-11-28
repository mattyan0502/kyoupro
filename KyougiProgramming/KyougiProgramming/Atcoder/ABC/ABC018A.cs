using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC018A
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int[] nums = { a, b, c };
            int max = 0;
            int min = 1000;
            for (int i = 0; i < 3; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            for(int i = 0; i < 3; i++)
            {
                if(nums[i] == max)
                {
                    Console.WriteLine(1);
                }
                else if(nums[i] == min)
                {
                    Console.WriteLine(3);
                }
                else
                {
                    Console.WriteLine(2);
                }
            }
            
        }
    }
}
