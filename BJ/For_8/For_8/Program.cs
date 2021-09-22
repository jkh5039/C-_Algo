using System;
using System.Text;
namespace For_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int[] A = new int[T];
            int[] B = new int[T];
            for (int i = 0; i < T; i++)
            {
                string[] sum = Console.ReadLine().Split(' ');
                A[i] = int.Parse(sum[0]);
                B[i] = int.Parse(sum[1]);
            }
            StringBuilder Case = new StringBuilder();

            for (int i = 0; i < T; i++)
            {
                int aPlusB = A[i] + B[i];
                Case.Append("Case #" + (i + 1) + ": " + A[i]+" + "+B[i]+" = ").Append(aPlusB).Append("\n");
            }

            Console.Write(Case.ToString());
        }
    }
}
