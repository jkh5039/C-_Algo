using System;
using System.Text;
using System.Numerics;
namespace Sort_3
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            BigInteger[] nums = new BigInteger[N];
            for (BigInteger i = 0; i < N; i++)
            {
                nums[i.Sign] = BigInteger.Parse(Console.ReadLine());
            }
            Array.Sort(nums);

            StringBuilder sb = new StringBuilder();
            for (BigInteger j = 0; j < N; j++)
            {
                sb.Append(nums[j]);
                sb.Append("\n");
            }
            Console.WriteLine(sb);
        }
    }
}
