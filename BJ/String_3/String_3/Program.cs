using System;
using static System.Console;
namespace String_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            
            for (int i=0; i< count; i++)
            {
                string[] Info = Console.ReadLine().Split();
                int num = int.Parse(Info[0]);
                string str = Info[1];
                for (int j=0; j<str.Length; j++)
                {
                    
                    for (int k=0; k < num; k++)
                    {
                        Write(str[j]);
                    }
                }
                Write("\n");
            }
            

        }
    }
}
