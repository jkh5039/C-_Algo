using System;

namespace NumTheory_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool go = true; //dont need
            while (go)
            {
                String[] nums = Console.ReadLine().Split();
                int x = int.Parse(nums[0]);
                int y = int.Parse(nums[1]);

                if (x == 0 && y == 0)
                    return;

                if (y % x == 0)
                    Console.WriteLine("factor");
                else if ((x % y == 0))
                    Console.WriteLine("multiple");
                else
                    Console.WriteLine("neither");
            }
            




        }
    }
}
