using System;

namespace Array_OX
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            string[] OX = new string[T];
            for(int i=0; i < T; i++)
            {
                OX[i] = Console.ReadLine();
                
            }

            int count=0;
            int score = 0;
            for(int j = 0; j < T; j++)
            {
                count = 0;
                score = 0;
                foreach(char a in OX[j])
                {
                    if (a == 'O')
                    {
                        count++;
                        score += count;
                    }
                    else
                    {
                        count = 0;
                    }
                }
                Console.WriteLine(score);

            }
        }
    }
}
