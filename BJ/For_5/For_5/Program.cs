using System;
using System.Text;

namespace For_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            StringBuilder Nums = new StringBuilder();
            for (int i=1; i<T+1; i++)
            {
                Nums.Append(i + "\n");
            }
            Console.WriteLine(Nums.ToString());
        }
    }
}
