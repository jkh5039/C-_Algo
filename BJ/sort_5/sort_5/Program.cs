using System;

namespace sort_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] nums= new int[N];
            for(int i=0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                nums[i] = x;
            }

            //check
            

            //Mean
            int mean = 0;
            for (int j = 0; j < N; j++)
            {
                mean += nums[j];
            }
            mean= mean/N;
            Console.WriteLine(mean);


            //Median
            int median = 0;
            Array.Sort(nums);
            int sort = ((N - 1) / 2)+1;            
            median = nums[sort - 1];
            Console.WriteLine(median);

            //Mode




            //Range
            int range = 0;
            range = nums[N - 1] - nums[0];
            Console.WriteLine(range);
        }


    }

    
}
