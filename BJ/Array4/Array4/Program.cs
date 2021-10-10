using System;

namespace Array4
{
    class Program
    {
        static void Main(string[] args)
        {
            ////서로 다른 나머지 갯수
            //int count = 0;
            ////입력받을 10개의 숫자
            //int[] Result = new int[10];
            ////입력받은 10개의 숫자
            //for(int i=0; i<10; i++)
            //{
            //    //곱해질수 2개
            //    int A = int.Parse(Console.ReadLine());
            //    int B = int.Parse(Console.ReadLine());
            //    //곱하고 42로 나누어진 결과 
            //    Result[i]= (A * B) % 42;             


            //}
            ////i번째숫자와 다른숫자들 비교한다                
            ////만약 나머지가 서로 다르다면 count를 추가한다 

            ////? 했던건 건드리면 안된다.
            //for (int j=0; j < 9;j++)
            //{
            //    for(int k=1; k <= 9; k++)
            //    {
            //        if (Result[j] != Result[k])
            //        {
            //            count++;
            //        }
            //    }
            //}

            //Console.WriteLine(count);

            const int CASE = 42;

            //Input part
            bool[] answer = new bool[CASE];
            //Cases True
            for (int i = 0; i < 10; i++)
                answer[int.Parse(Console.ReadLine()) % CASE] = true;

            int count = 0;
            //BoolCount 
            for (int i = 0; i < CASE; i++)
                if (answer[i])
                    count++;

            Console.WriteLine(count);
        }
    }
}
