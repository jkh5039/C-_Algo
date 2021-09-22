using System;

namespace While_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();
                

                if (s == null)
                {
                    break;
                }
                string[] ss = s.Split();
                int a = int.Parse(ss[0]);
                int b = int.Parse(ss[1]);
                int Sum = a + b;

                
                Console.WriteLine(Sum);
            }
        }
    }
}
