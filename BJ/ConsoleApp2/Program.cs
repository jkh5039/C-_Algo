using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();           
            int Score = Convert.ToInt32(s);
            //@@
            if(Score>=90&& Score <= 100)
            {
                Console.WriteLine("A");
            }
            if (Score >= 80 && Score <= 89)
            {
                Console.WriteLine("B");
            }
            if (Score >= 70 && Score <= 79)
            {
                Console.WriteLine("C");
            }
            if (Score >= 60 && Score <= 69)
            {
                Console.WriteLine("D");
            }
            if (Score >= 0 && Score <= 59)
            {
                Console.WriteLine("F");
            }



        }
    }
}
