using System;

namespace String_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string Croatia = Console.ReadLine();
            //int worldLen = Croatia.Length;
            string[] Cword = { "dz=", "c=", "c-", "d-", "lj", "nj", "s=", "z=" };
            for(int i=0; i < Cword.Length; i++)
            {
                if (Croatia.Contains(Cword[i]))
                {
                    Croatia = Croatia.Replace(Cword[i], "0");
                }
                else
                {
                    continue;
                }
            }


            //Console.WriteLine(Croatia);
            Console.WriteLine(Croatia.Length);
        }
    }
}
