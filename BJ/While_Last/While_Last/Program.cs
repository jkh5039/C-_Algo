using System;

namespace While_Last
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int ss = int.Parse(s);
            if (ss < 10)
            {
                ss= ss * 10;
            }
            int Original = ss;
            int count = 0;
            
            

            //Console.WriteLine(ss);
            //Console.WriteLine(ss);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            while (true)
            {
                int Num10 = ss / 10;
                int Num1 = ss % 10;
                int Newnum = Num10 + Num1;
                ss = Num1 * 10 + Newnum % 10;
                count++;
                if(ss== Original)
                {
                    break;
                }
                
            }
            Console.WriteLine(count);
            
        }
    }
}
