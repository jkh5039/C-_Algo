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
            while (num > x)
            {
                //층수 올라감
                layer++;
                //층수의 최대숫자
                num += layer; 
            }
            int start = num - layer + 1; //분모시작 최소숫자
            int last = num; //해당 레이어 마지막 숫자.

        }
    }
}
