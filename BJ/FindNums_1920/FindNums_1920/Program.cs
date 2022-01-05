using System;

namespace FindNums_1920
{
    class Program
    {
        static void Main(string[] args)
        {
            int CountN = int.Parse(Console.ReadLine());
            int[] N = new int[CountN];
            string[] numsN = Console.ReadLine().Split();

            for(int i=0; i < CountN; i++)
            {
                N[i] = int.Parse(numsN[i]);
            }

            int CountM = int.Parse(Console.ReadLine());
            int[] M = new int[CountM];
            string[] numsM = Console.ReadLine().Split();

            for(int j = 0; j < CountM; j++)
            {
                M[j] = int.Parse(numsM[j]);
            }
            int cnt = 0;
            for(int k = 0; k < M.Length; k++)
            {
                cnt = 0;
                for(int l=0; l < N.Length; l++)
                {
                    if (M[k] == N[l])
                    {
                        Console.WriteLine(1);
                        break;
                    }
                    else
                    {
                        cnt++;
                    }
                    if (cnt == M.Length)
                    {
                        Console.WriteLine(0);
                    }


                }
                
            }
        }
    }
}
