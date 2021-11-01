using System;

namespace BasicMath1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] snail = Console.ReadLine().Split();
            int days = 0;
            int meters = 0;
            int A = int.Parse(snail[0]);
            int B = int.Parse(snail[1]);
            int V = int.Parse(snail[2]);


            while (true)
            {
                days++;
                meters += A;
                if (meters >= V)
                {
                    break;
                }
                meters -= B;              
                
                
                
                
                
            }
            Console.WriteLine(days);
        }
    }
}
