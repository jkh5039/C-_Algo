using System;
using System.Collections.Generic;
//using System.Linq;
namespace Sort_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            string[] words = new string[T];
            List<string> wordSort = new List<string>();
            //Console.WriteLine(wordSort.Count);
            int len = 1;
            
            for(int i = 0; i < T; i++)
            {
                string X = Console.ReadLine();
                words[i] = X;
            }
                       

            //알파벳순서대로 정렬
            Array.Sort(words);

            for(int p = 0; p < T; p++)
            {
                Console.WriteLine(words[p]);
            }
            // words 중복 제거

            // -> 11개
            //while(wordSort.Count != words)
            //{
            //    if (asdf)
            //        wordSort.Add();
            //}

            while (wordSort.Count== T)
            {
                Console.WriteLine("while들어감");

                for (int j = 0; j < T; j++)
                {
                    if (words[j].Length == len)
                    {
                        wordSort.Add(words[j]);
                        Console.WriteLine(wordSort.Count);
                    }
                    Console.WriteLine("들어감");
                }
                len++;
            }

            Console.WriteLine(wordSort.Count);
            //for(int k = 0; k < T; k++)
            //{
            //    Console.WriteLine(wordSort[k]);
            //}


        }
    }
}
