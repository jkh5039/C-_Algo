using System;

namespace BasicMath2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split();
            int count = nums.Length;
            //Try
            for(int i=0; i < T; i++)
            {
                if (int.Parse(nums[i]) == 1)
                {
                    count--;
                }
                // 2~ number itself-1
                for (int j=2; j< int.Parse(nums[i])-1; j++)
                {                    
                    if ( int.Parse(nums[i])%j==0)
                    {
                        count--;
                        break;
                    }
                }

            }
            Console.WriteLine(count);
        }
    }
}
