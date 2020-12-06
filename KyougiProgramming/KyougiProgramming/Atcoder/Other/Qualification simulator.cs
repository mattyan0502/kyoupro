using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.Other
{
    class Qualification_simulator
    {
        public static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int n = int.Parse(line[0]);
            int a = int.Parse(line[1]);
            int b = int.Parse(line[2]);
            string s = Console.ReadLine();
            int abCount = 0;
            int bCount = 0;
            foreach(char ch in s)
            {
                string result = string.Empty;
                if (ch == 'a')
                {
                    if(abCount < a + b)
                    {
                        result = "Yes";
                        abCount++;
                    }
                    else
                    {
                        result = "No";
                    }
                }
                else if(ch == 'b')
                {
                    if(abCount < a + b && bCount < b)
                    {
                        result = "Yes";
                        abCount++;
                        bCount++;
                    }
                    else
                    {
                        result = "No";
                    }
                }
                else
                {
                    result = "No";
                }
                Console.WriteLine(result);
            }
        }
    }
}
