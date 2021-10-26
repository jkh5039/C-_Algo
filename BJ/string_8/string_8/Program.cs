using System;

namespace string_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToUpper();
            int sum = 0;

            

            for(int i=0; i < word.Length; i++)
            {
                if (word[i] == 'A' || word[i] == 'B' || word[i] == 'C')
                {
                    sum += 2;
                }
                else if (word[i] == 'D' || word[i] == 'E' || word[i] == 'F')
                {
                    sum += 3;
                }
                else if (word[i] == 'G' || word[i] == 'H' || word[i] == 'I')
                {
                    sum += 4;
                }
                else if (word[i] == 'J' || word[i] == 'K' || word[i] == 'L')
                {
                    sum += 5;
                }
                else if (word[i] == 'M' || word[i] == 'N' || word[i] == 'O')
                {
                    sum += 6;
                }
                else if (word[i] == 'P' || word[i] == 'Q' || word[i] == 'R' || word[i] == 'S')
                {
                    sum += 7;
                }
                else if (word[i] == 'T' || word[i] == 'U' || word[i] == 'V')
                {
                    sum += 8;
                }
                else if (word[i] == 'W' || word[i] == 'X' || word[i] == 'Y' || word[i] == 'Z')
                {
                    sum += 9;
                }
            }
            
            
            Console.WriteLine(sum+word.Length);
        }
    }
}
