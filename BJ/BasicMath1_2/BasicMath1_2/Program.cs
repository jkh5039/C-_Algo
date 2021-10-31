using System;

namespace BasicMath1_2
{
    class Program
    {

        static void Main(string[] args)
        {
            
            int x = int.Parse(Console.ReadLine());

            int pos = 0;
            int range = 1;
            int sequence = 1;
            //if (x == 1)
            //{
            //    Console.WriteLine(1);
            //}

            while (true)
            {
                pos++;
                if (range >=x)
                {
                    break;
                }
                
                sequence = 6 * pos;
                range += sequence;

            }

            if (x == 1)
            {
                pos = 1;
            }
            Console.WriteLine(pos);
            
        }
    }
}
