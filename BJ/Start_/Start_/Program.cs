using System;

namespace Start_
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int A = int.Parse(a);
            int B = int.Parse(b);


            Console.WriteLine(A * (B % 10));
            Console.WriteLine(A * ((B % 100) / 10));
            Console.WriteLine(A * (B / 100));
            Console.WriteLine(A * B);

        }
    }
}



