using System;

namespace BasicMath2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] xywh = Console.ReadLine().Split();
            int x = int.Parse(xywh[0]);
            int y = int.Parse(xywh[1]);
            int w = int.Parse(xywh[2]);
            int h = int.Parse(xywh[3]);

            int x1 = x;
            int y1 = y;
            int w1 = w - x;
            int h1 = h - y;
            int[] nums = new int[] {x1,y1,w1,h1};

            int min = nums[0];
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }

            Console.WriteLine(min);
            
        }
    }
}
