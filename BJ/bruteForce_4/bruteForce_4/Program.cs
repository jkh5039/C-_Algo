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
            for (int i = 0; i < cards.Length-2; i++) //3번째
            {
                for(int j=0; j < cards.Length-1; j++) //2번째
                {
                    for(int k=0; k < cards.Length; k++) //1번째
                    {
                        if(int.Parse(cards[i]+ cards[j]+ cards[k]) == maximum)
                        {
                            Console.WriteLine(maximum);
                            return;
                        }

                    }
                }
            }
        }
    }
}
