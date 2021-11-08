using System;

namespace BasicMath_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            
            int layer = 1;
            int num = 1;

            int denominator=0; //분모 
            int numerator=0; //분자
            while (num < x)
            {
                //층수 올라감
                layer++;
                //층수의 최대숫자
                num += layer; 
            }
            int start = num - x + 1;   
            //start 
            //만약 레이어가 짝수이면 분모가 큰상태로 시작 
            
            if (layer % 2 == 0)
            {
                numerator = layer+1-start;
                denominator = start;

                
            }
            if(layer % 2 == 1)
            {
                numerator = start;
                denominator = layer + 1 - start;
            }
            //만약 홀수라면 홀수라면 분자가 큰상태로 시작
            //int last = num; //해당 레이어 마지막 숫자.
            Console.WriteLine(numerator+"/"+ denominator);
            

        }
    }
}
