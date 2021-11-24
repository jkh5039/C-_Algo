using System;

namespace recursion_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int factorial = 1;
            if (N == 0)
            {
                factorial = 1;
            }
            
            while (N > 1)
            {
                factorial *= N;
                N--;
            }
            Console.WriteLine(factorial);
        }
    }
}
