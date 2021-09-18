using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ');
            int H = int.Parse(a[0]);
            int M = int.Parse(a[1]);

            if (M >= 45)
            {
                M = M - 45;
            }
            else if (H >= 1 && M < 45)
            {
                H = H - 1;
                M = M + 60 - 45;
            }
            else if (H == 0 && M < 45)
            {
                H = H + 24 - 1;
                M = M + 60 - 45;
            }

            Console.WriteLine("{0} {1}", H, M);

        }
    }
}
