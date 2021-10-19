using System;

namespace String_2
{   


    class Program
    {
        static void Main(string[] args)
        {
            int Count = int.Parse(Console.ReadLine());
            string nums = Console.ReadLine();
            int sum=0;
            for(int i=0; i < Count; i++)
            {
                sum +=  int.Parse(nums[i].ToString());
            }
            Console.WriteLine(sum);
        }
        //배열로 쓴 문자열은 char형식이다 고로 문자열로 전환 해줘야함
    }
}
