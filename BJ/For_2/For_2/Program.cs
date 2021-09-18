using System;

namespace For_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            
            for (int i=0; i<T; i++)
            {
                string[] num = Console.ReadLine().Split(' ');
                int A = int.Parse(num[0]);
                int B = int.Parse(num[1]);
                Console.WriteLine(A + B);
            }
            
        }
    }
}
