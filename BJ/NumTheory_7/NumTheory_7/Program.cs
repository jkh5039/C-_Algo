using System;

namespace NumTheory_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int N = int.Parse(nums[0]);
            int bunja=1;
            int K = int.Parse(nums[1]);
            int bunmo = 1;
            for(int i = 0; i < K; i++)
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
