using System;

namespace Baekjoon
{
    class Program
    {
        static void Main()
        {

            string s = Console.ReadLine();
            string[] ss = s.Split();
            int A = int.Parse(ss[0]);
            int B = int.Parse(ss[1]);
            if (A > B)
            {
                Console.WriteLine(">");
            }
            else if (A == B)
            {
                Console.WriteLine("==");
            }
            else
            {
                Console.WriteLine("<");
            }            
            
        }
    }
}
