using System;

namespace bruteForce_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int answer = 0;
            int i = 0;
            while (N > 0)
            {                
                if (i.ToString().Contains("666"))
                {
                    answer = i;
                    N--;
                }                
                i++;
            }
            Console.WriteLine(answer);
        }
    }
}
