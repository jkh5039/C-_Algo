using System;

namespace Array_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int[] nums = new int[T];
            string[] Arrays = Console.ReadLine().Split();

            for(int i=0; i<nums.Length; i++)
            {
                nums[i] = int.Parse(Arrays[i]);
            }

            Array.Sort(nums);
            //Console.WriteLine($"{nums[0]} {nums[nums.Length - 1]}");
            Console.WriteLine(nums[0] + " " + nums[nums.Length - 1]);
        }
    }
}
