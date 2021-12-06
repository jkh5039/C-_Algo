using System;

namespace bruteForce_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] N = Console.ReadLine().Split();
            int x = int.Parse(N[0]);
            int maximum = int.Parse(N[1]);
            int points = 0;
            int result = 0;
            string[] cards = Console.ReadLine().Split();


            //cards.Length...moji,,, 
            for (int i = 0; i < cards.Length-2; i++)
            {
                for(int j=0; j < cards.Length-1; j++)
                {
                    for(int k=0; k < cards.Length; k++)
                    {

                    }
                }
            }
        }
    }
}
