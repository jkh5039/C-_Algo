using System;

namespace For_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int T= int.Parse(Console.ReadLine());
            string[] num = Console.ReadLine().Split(' ');
            
            for (int i = 0; i < T; i++)
            {
                int A = int.Parse(num[0]);
                int B = int.Parse(num[1]);
                Console.WriteLine(A + B);
            }
        }
    }
}
