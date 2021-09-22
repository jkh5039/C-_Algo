using System;

namespace While_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();
                string[] ss = s.Split();
                int a = int.Parse(ss[0]);
                int b = int.Parse(ss[1]);
                int Sum = a + b;

                if (a == 0 && b == 0)
                    break;

                Console.WriteLine(Sum);
            }




        }
    }
}
