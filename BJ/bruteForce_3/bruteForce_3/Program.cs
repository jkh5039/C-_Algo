using System;

namespace bruteForce_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] x = new int[N];
            int[] y = new int[N];
            int rank = 0;
            for(int i = 0; i < N; i++)
            {
                string[] info = Console.ReadLine().Split();
                x[i] = int.Parse(info[0]);
                y[i] = int.Parse(info[1]);
            }

            //for(int j = 0; j < N; j++)
            //{
            //    Console.WriteLine(x[j]);
            //    Console.WriteLine(y[j]);
            //}

            for(int k=0; k < N; k++)
            {
                rank = 1;
                for(int l = 0; l < N; l++)
                {
                    if (x[k] < x[l] && y[k] < y[l])
                    {
                        rank++;
                    }
                }
                Console.WriteLine(rank);
            }
        }
    }
}
