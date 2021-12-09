using System;
using System.Text;
namespace Sort_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] nums = new int[N];
            for(int i = 0; i < N; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(nums);

            StringBuilder sb = new StringBuilder();
            for(int j = 0; j < N; j++)
            {
                sb.Append(nums[j]);
                sb.Append("\n");
            }
            Console.WriteLine(sb);
        }
    }
}
