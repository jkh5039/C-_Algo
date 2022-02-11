using System;

namespace CCW_11758
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://degurii.tistory.com/47

            string[] p1 = Console.ReadLine().Split();
            int x1 = int.Parse(p1[0]);
            int y1 = int.Parse(p1[1]);

            string[] p2 = Console.ReadLine().Split();
            int x2 = int.Parse(p2[0]);
            int y2 = int.Parse(p2[1]);

            string[] p3 = Console.ReadLine().Split();
            int x3 = int.Parse(p3[0]);
            int y3 = int.Parse(p3[1]);

            int ccw = (x1 * y2) + (x2 * y3) + (x3 * y1) 
                - ((y1 * x2) + (y2 * x3) + (y3 * x1));

            if (ccw == 0)
                Console.WriteLine("0");
            else if (ccw > 0)
                Console.WriteLine("1");
            else if (ccw < 0) 
                Console.WriteLine("-1");



        }
    }
}
