using System;

namespace NumTheory_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int k=0; k < T; k++)
            {
                string[] nums = Console.ReadLine().Split();
                int N = int.Parse(nums[0]);
                int K = int.Parse(nums[1]);
                int temp;
                int bunja = 1;
                int bunmo = 1;
                if (N == K)
                {
                    Console.WriteLine(1);
                }

                else if (N > K)
                {
                    for (int i = 0; i < K; i++)
                    {
                        bunja *= N;
                        N--;
                    }
                    while (K != 0)
                    {
                        bunmo *= K;
                        K--;
                    }
                    Console.WriteLine(bunja / bunmo);
                }
                else if (N < K)
                {
                    temp = N;
                    N = K;
                    K = temp;
                    for (int i = 0; i < K; i++)
                    {
                        bunja *= N;
                        N--;
                    }
                    while (K != 0)
                    {
                        bunmo *= K;
                        K--;
                    }
                    Console.WriteLine(bunja / bunmo);
                }
            }
            

        }
    }
}
