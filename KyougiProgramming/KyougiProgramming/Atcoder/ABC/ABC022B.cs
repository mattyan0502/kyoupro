using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC022B
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> ansList = new List<int>();
            for(int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if(ansList.Contains(a) == false)
                {
                    ansList.Add(a);
                }
            }
            int ans = n - ansList.Count;
            Console.WriteLine(ans);
        }
    }
}
