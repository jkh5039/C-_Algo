using System;
using System.Text;

namespace For_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            StringBuilder Nums = new StringBuilder();
            for (int i = T; i >0; i--)
            {
                Nums.Append(i + "\n");
            }
            Console.WriteLine(Nums.ToString());
        }
    }
}
