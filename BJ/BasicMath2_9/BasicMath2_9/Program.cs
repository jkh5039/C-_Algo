using System;

namespace BasicMath2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                string[] nums = Console.ReadLine().Split();
                
                int x = int.Parse(nums[0]);
                int y = int.Parse(nums[1]);
                int z = int.Parse(nums[2]);
                

                if (x == 0 && y == 0 && z == 0)
                    return;

                if (x * x + y * y == z * z ||
                    x * x + z * z == y * y ||
                    y * y + z * z == x * x)
                    Console.WriteLine("right");

                else                
                    Console.WriteLine("wrong");                
            }
            
        }
    }
}
