using System;

namespace recursion_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());


            //n-2
            int temp1 = 0;
            //n-1
            int temp2 = 1;
            //n
            int temp = 0;

            int k = 0;

            while (n - 1 > k)
            {

                //k번째 수 등장
                temp = temp1 + temp2;
                //k-2번째 수 배치
                temp1 = temp2;
                //k-1수 배치
                temp2 = temp;
                k++;

            }
            if (n == 0)
            {
                temp = 0;
            }
            if (n == 1)
            {
                temp = 1;
            }
            if (n == 2)
            {
                temp = 1;
            }
            Console.WriteLine(temp);
        }
    }
}
