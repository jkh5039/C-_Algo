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

            
            int result = 0;
            string[] cards = Console.ReadLine().Split();


            //cards.Length.. 
            for (int i = 0; i < cards.Length - 2; i++) 
            {
                for (int j = i + 1; j < cards.Length - 1; j++) 
                {
                    for (int k = j + 1; k < cards.Length; k++) 
                    {
                        int sum = int.Parse(cards[i]) + int.Parse(cards[j])+
                            int.Parse(cards[k]);
                        
                        //equal
                        if (sum == maximum)
                        {
                            Console.WriteLine(maximum);
                            return;
                        }


                        //over
                        if (sum > maximum)
                        {
                            continue;
                        }



                        //less                        
                        if (sum < maximum)
                        {
                            if(sum>result)
                                result = sum;
                            
                        }
                    }
                }
            }
            Console.WriteLine(result);
        }

        

    }
}
