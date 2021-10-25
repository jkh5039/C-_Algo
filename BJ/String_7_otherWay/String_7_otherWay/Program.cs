using System;

namespace String_7_otherWay
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            char number0 = nums[0][0];
            char number1 = nums[0][1];            
            char number2 = nums[0][2];
            string nums1 = number2.ToString() + number1.ToString() + number0.ToString();
            int A=int.Parse(nums1);
            //Console.WriteLine(A);

            char number3 = nums[1][0];
            char number4 = nums[1][1];
            char number5 = nums[1][2];
            string nums2 = number5.ToString() + number4.ToString() + number3.ToString();
            int B = int.Parse(nums2);
            //Console.WriteLine(B);

            if (A > B)
            {
                Console.WriteLine(A);
            }
            else if (B > A)
            {
                Console.WriteLine(B);
            }



        }
    }
}
