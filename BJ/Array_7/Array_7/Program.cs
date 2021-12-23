using System;

namespace Array_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int sum=0;
            float avg = 0;
            float cnt = 0;
            float result = 0;
            for (int i = 0; i < A; i++)
            {                
                string[] nums = Console.ReadLine().Split();
                int T = int.Parse(nums[0]);
                for(int j = 1; j < nums.Length;j++)
                {
                    sum += int.Parse(nums[j]);
                }
                //Console.WriteLine(sum);
                //Console.WriteLine(T);
                avg = sum / T;
                //Console.WriteLine(avg);
                for(int k = 1; k < nums.Length; k++)
                {
                    if (int.Parse(nums[k]) > avg)
                    {
                        cnt++;
                    }
                }
                //Console.WriteLine(cnt);
                //Console.WriteLine(cnt / T);
                result = (cnt / T) * 100;
                double R = Math.Round(result, 3);
                Console.WriteLine(R);
            } 
            
        }
    }
}
