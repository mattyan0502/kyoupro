using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC025B
    {
        public static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int n = int.Parse(line[0]);
            int a = int.Parse(line[1]);
            int b = int.Parse(line[2]);
            for(int i = 0; i < n; i++)
            {
                string[] sd = Console.ReadLine().Split(' ');
                string s = sd[0];
                int d = int.Parse(sd[1]);
                if(d < a)
                {
                    if(s  == "East")
                    {
                        n = n - a;
                    }
                    else
                    {
                        n = n + a;
                    }
                }
                else if(a <= d && d <= b)
                {
                    if(s == "West")
                    {
                        n = n - d;
                    }
                    else
                    {
                        n = n + d;
                    }    
                }
                else if(d > b)
                {
                    if(s =="West")
                    {
                        n = n - b;
                    }
                    else
                    {
                        n = n + b;
                    }
                }
            }
            Console.WriteLine(n);
        }
    }
}
