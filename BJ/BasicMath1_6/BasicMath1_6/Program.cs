using System;

namespace BasicMath1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.acmicpc.net/problem/2775


            int T = int.Parse(Console.ReadLine());
            for(int i=0; i < T; i++)
            {
                int k = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                int start = 1;
                int sum = 1;
                //호수
                int room = 1;
                //층수
                int layer = 0;
                //1층에있는걸 계산할때 1층
                while (room<n) //호수를 채운다
                {
                    start++;
                    sum += start;
                    room++;                   
                    
                }

                //2층 다음푸터는 어떻게?
                
                
                //1호는 다 1로 바꾼다
                if (n == 1)
                {
                    sum = 1;
                }
                Console.WriteLine(sum);
                
                

            }
        }
    }
}
