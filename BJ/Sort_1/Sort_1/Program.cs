using System;

namespace Sort_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] nums = new int[N];
            for (int i = 0; i < N; i++)
            {
                int num = int.Parse(Console.ReadLine());
                nums[i] = num;
            }
            Array.Sort(nums);

            for (int j = 0; j < N; j++)
            {
                Console.WriteLine(nums[j]);
            }
        }
    }
}
