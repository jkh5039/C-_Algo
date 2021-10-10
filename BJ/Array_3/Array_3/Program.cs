using System;


namespace Array_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int num = A * B * C;
            string Nums = num.ToString();
            //int[] Answer = new int[10];
            int count = 0;
            for(int i = 0; i < 10; i++)
            {
                for(int j=0; j < Nums.Length; j++)
                {
                    if (Nums[j].ToString() == i.ToString())
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                count = 0;
            }

        }
    }
}
