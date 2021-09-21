using System;

namespace ConsoleApp6
{
    class Program
    {
        int T = int.Parse(Console.ReadLine());
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 1; i <= T; i++)
            {
                string[] num = Console.ReadLine().Split(' ');
                int A = int.Parse(num[0]);
                int B = int.Parse(num[1]);
                Console.WriteLine("Case #"+i+": " +(A + B));

            }
        }
    }
}
