using System;
using System.Text;
namespace For_9
{
    class Program
    {

        //static void Main(string[] args) 
        //{
        //    string stars = "*";
        //    string star = "*";

        //    int Stars =int.Parse(Console.ReadLine());
        //    for(int i = 0; i < Stars; i++)
        //    {
        //        Console.Write(stars+"\n");
        //        stars += star;
        //    }
        //}

        static void Main(string[] args)
        {
            string blanks = "";
            string blank = " ";
            string stars = "*";
            string star = "*";

            int Stars = int.Parse(Console.ReadLine());
            for (int i = 0; i < Stars; i++)
            {
                for (int j=Stars; i<j-1; j--)
                {
                    blanks += blank;
                }

                Console.Write(blanks+stars + "\n");
                stars += star;
                blanks = "";

            }
        }
    }
}
