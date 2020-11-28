using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC021B
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');
            int a = int.Parse(line[0]);
            int b = int.Parse(line[1]);
            int K = int.Parse(Console.ReadLine());
            int[] nums = new int[K + 2];
            nums[0] = a;
            nums[K + 1] = b;
            string result = "YES";
            string[] P = Console.ReadLine().Split(' ');
            for(int i = 1; i < K + 1; i++)
            {
                int num = int.Parse(P[i - 1]);
                if (nums.Contains(num) == false)
                {
                    nums[i] = num;
                }
                else
                {
                    result = "NO";
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
