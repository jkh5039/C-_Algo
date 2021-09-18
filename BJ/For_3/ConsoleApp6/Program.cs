using System;

namespace ConsoleApp6
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int sum=0;
            int num = int.Parse(Console.ReadLine());
            for(int i=1; i < num+1; i++)
            {
                sum+= i;
            }
            Console.WriteLine(sum);
        }
    }
}
