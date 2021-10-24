using System;
using System.Linq;


namespace String_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();

            //Console.WriteLine(nums.Length);
            string num1 = new string(nums[0].ToCharArray().Reverse().ToArray());
            string num2 = new string(nums[1].ToCharArray().Reverse().ToArray());
            int number1 = int.Parse(num1);
            int number2 = int.Parse(num2);
            if (number1 > number2)
            {
                Console.WriteLine(number1);
            }
            else if (number2 > number1)
            {
                Console.WriteLine(number2);
            }





        }
    }
}
