using System;

namespace string_5
{
    class Program
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine();
            word = word.ToUpper();
            int count = 0;
            char[] abc = { 'A','B','C','D','E','F','G','H','I',
            'J','K','L','M','N','O','P','Q',
            'R','S','T','U','V','W','X','Y','Z'};

            int[] abcCount = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            //abc 카운트 배열 하나씩 비교하면서 겹치는거 올린다
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < abc.Length; j++)
                {
                    if (word[i] == abc[j])
                    {
                        abcCount[count]++;
                    }
                    count++;
                }
                count = 0;
            }

            //그냥 갯수 확인하는용도
            for (int i = 0; i < abcCount.Length; i++)
            {
                //Console.WriteLine(abcCount[i]);
            }

            //갯수확인 위해서 만든거임
            int max = 0;
            foreach (var num in abcCount)
            {
                if (max < num)
                {
                    max = num;
                }
            }
            //Console.WriteLine(max); //최대 갯수


            //중복 확인위해 
            //만약 max값이 같다면 countX 1씩 더한다
            int countX = 0;
            foreach (var num in abcCount)
            {
                if (max == num)
                {
                    countX++;
                }
            }
            //Console.WriteLine(countX);

            int index = Array.IndexOf(abcCount, max);

            //만약 countX가 1보다 크다면 (중복되었다는 뜻) ?출력

            // 그렇지 않고 1이라면, 
            if (countX == 1)
            {
                //최댓값의 위치를 찾는다
                //Console.WriteLine(index);
                Console.WriteLine(abc[index]);
            }
            else
            {
                Console.WriteLine("?");
            }

        }
    }
}
