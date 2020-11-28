using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyougiProgramming.Atcoder.ABC
{
    class ABC019B
    {
        public static void Main(string[] args)
        {
            string S = Console.ReadLine();
            List<string> wordList = new List<string>();
            string word = string.Empty;
            string nWord = string.Empty;
            for (int i = 0; i < S.Length - 1; i++)
            {
                if (i == S.Length - 2)
                {
                    if (S[i] == S[i + 1])
                    {
                        word = word + S[i] + S[i + 1];
                        wordList.Add(word);
                    }
                    else
                    {
                        word = word + S[i];
                        wordList.Add(word);
                        nWord = S[i + 1].ToString();
                        wordList.Add(nWord);
                    }
                }
                else
                {
                    if (S[i] == S[i + 1])
                    {
                        word = word + S[i];
                    }
                    else
                    {
                        word = word + S[i];
                        wordList.Add(word);
                        word = string.Empty;
                    }
                }
            }
            for (int i = 0; i < wordList.Count; i++)
            {
                string strin = wordList[i];
                string str = strin[0].ToString();
                wordList[i] = str + wordList[i].Length;
            }
            string result = string.Empty;
            foreach (string ans in wordList)
            {
                result += ans;
            }
            Console.WriteLine(result);
        }
    }
}