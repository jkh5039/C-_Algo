using System;
using System.Numerics;

namespace BasicMath1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split();
            BigInteger x = BigInteger.Parse(num[0]);
            BigInteger y = BigInteger.Parse(num[1]);
            Console.WriteLine(x + y);
        }
    }
}
