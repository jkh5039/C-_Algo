using System;

namespace BasicMath2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int sum = 0;
            int min = 0;
            for (int k = M; k <= N; k++)
            {
                sum += k;
            }
            
            for (int i = M; i <= N; i++)
            {
                if (i == 1)
                {
                    sum -= 1;
                }

                

                for (int j = 2; j <= i - 1; j++)
                {
                    if(min==0&& i % j != 0)
                    {
                        min = i;
                    }

                    if (i % j == 0)
                    {

                        
                        sum -= i;
                        
                        break;
                    }
                }
                if (i == 2)
                {
                    min = 2;
                }
                
                
            }
            if (sum == 0)
            {
                sum = -1;
            }
            Console.WriteLine(sum);
            if(sum!= -1)
            {
                Console.WriteLine(min);

            }
        }
    }
}
