using System;

namespace bruteForce_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //answer
            int N = int.Parse(Console.ReadLine());
            
            //sum
            int sum = 0;           
            int answer=0;
            int realI = 0;
            int others = 0;
            for (int i = 1; i <N; i++) 
            {
                realI = i;
                //합 초기화 
                sum = 0;
                others = 0;
                sum += i;

                while (i != 0)
                {
                    others += i % 10;
                    i /= 10;

                }
                sum += others;
                //N값 바꾼다
                i = realI;

                //sum값이 N과 같으면 나간다

                if (N == sum)
                {
                    answer = i;
                    Console.WriteLine(answer);
                    return;
                }


                else
                    continue;
                answer = 0;




            }
            Console.WriteLine(answer);
        }
    }
}
