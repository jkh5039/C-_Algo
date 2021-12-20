using System;
using System.Collections.Generic;


namespace BasicMath2_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int sosu = 0;
            List<int> list = new List<int>();
            for(int i = M; i <= N; i++)
            {
                sosu = 0;
                if (i > 1)
                {
                    for (int j = 2; j <= i; j++)
                    {
                        if (i / j == 0)
                        {
                             
                        }
                    }
                }
            }
        }
    }
}
