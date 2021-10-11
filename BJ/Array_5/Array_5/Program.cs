using System;
using static System.Console;
namespace Array_5
{
    class Program
    {
        static void Main(string[] args)
        {
            float temp = 0;
            float score = 0;

            int N = int.Parse(Console.ReadLine());

            string[] numbers = Console.ReadLine().Split();
            float[] nums = Array.ConvertAll(numbers, float.Parse);
            //int[] nums = new int[N];
            //for(int i=0; i<N; i++)
            //{
            //    nums[i] = int.Parse(Console.ReadLine());
            //}

            for(int j=0; j < N; j++)
            {
                
                if (nums[j] > temp)
                {
                    temp = nums[j];
                }

            }

            

            for (int k = 0; k < N; k++)
            {
                score += (nums[k] / temp)*100;                
            }
            float avg = score / N;
            Console.WriteLine(avg);
        }
    }
}
