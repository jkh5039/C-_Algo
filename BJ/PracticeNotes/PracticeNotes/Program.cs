using System;

namespace PracticeNotes
{

    
    class Program
    {

        static int Solution(int[] a, int[] b)
        {

            int answer = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int sum = a[i] * b[i];
                answer += sum;
            }
            return answer;
        }

        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 1, 2, 3 };            
            Console.WriteLine(Solution(a,b));

        }
        
        
    }
}
