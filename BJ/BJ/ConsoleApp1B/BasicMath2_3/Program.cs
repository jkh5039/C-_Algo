using System;

namespace BasicMath2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            //int K = N;
            for(int i=2; i <= N; i++)
            {
                while (N % i == 0)
                {
                    Console.WriteLine(i);
                    N = N / i;
                }
            }
        }
    }
}
