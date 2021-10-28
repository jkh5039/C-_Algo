using System;

namespace BasicMath1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] point = Console.ReadLine().Split();
            int A = int.Parse(point[0]);
            int B = int.Parse(point[1]);
            int C = int.Parse(point[2]);

            if (C - B <= 0) Console.WriteLine(-1);
            else 
            {
                Console.WriteLine((A / (C - B)) + 1);
            }
        }
    }
}
