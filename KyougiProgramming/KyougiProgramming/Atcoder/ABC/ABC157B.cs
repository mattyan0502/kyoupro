using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC157B
    {
        public static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            for(int i = 0; i < 3; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for(int j = 0; j < 3; j++)
                {
                    a[i, j] = int.Parse(line[j]);
                }
            }
            int n = int.Parse(Console.ReadLine());
            for(int k = 0; k < n; k++)
            {
                int b = int.Parse(Console.ReadLine());
                for(int l = 0; l < 3; l++)
                {
                    for(int m = 0; m < 3; m++)
                    {
                        if(b == a[l,m])
                        {
                            a[l, m] = 0;
                        }
                    }
                }
            }
            string result = "No";
            for(int o = 0; o < 3; o++)
            {
                if(a[o,0] == 0 && a[o,1] == 0 && a[o,2] == 0)
                {
                    result = "Yes";
                }
                if(a[0,o] == 0 && a[1,o] == 0 && a[2,o] == 0)
                {
                    result = " Yes";
                }
            }
            if(a[0,0] == 0 && a[1,1] == 0 && a[2,2] == 0)
            {
                result = "Yes";
            }
            if(a[0,2] == 0 && a[1,1] == 0 && a[2,0] == 0)
            {
                result = "Yes";
            }
            Console.WriteLine(result);
        }
    }
}
