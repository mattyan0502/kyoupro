using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC018B
    {
        public static void Main(string[] args)
        {
            string S = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            List<string> strList = new List<string>();
            for(int i = 0; i < S.Length; i++)
            {
                strList.Add(S[i].ToString());
            }
            for(int i = 0; i < num; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                int l = int.Parse(str[0]);
                int r = int.Parse(str[1]);
                strList.Reverse(l - 1,r - l + 1);
            }
            string result = string.Empty;
            for(int i = 0; i < S.Length; i++)
            {
                result += strList[i];
            }
            Console.WriteLine(result);
        }
    }
}
