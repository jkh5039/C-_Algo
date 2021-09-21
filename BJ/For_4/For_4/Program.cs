using System;
using System.Text;

namespace For_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int T= int.Parse(Console.ReadLine());
            StringBuilder abNumbers = new StringBuilder();

            for (int i = 0; i < T; i++)
            {
                string[] num = Console.ReadLine().Split(' ');
                int A = int.Parse(num[0]);
                int B = int.Parse(num[1]);
                abNumbers.Append(A+B + "\n");
                
            }
            Console.WriteLine(abNumbers.ToString());
        }
    }
}
