using System;
using System.Collections.Generic;
using System.Text;

namespace Queue_10845
{
    public static class Queue
    {
        public static uint back(this Queue<uint> q)
        {
            List<uint> l = new List<uint>();
            for(int i =0;i< q.Count-1; ++i)
            {
                l.Add(q.Dequeue());
            }
            var temp = q.Dequeue();
            l.Add(temp);

            foreach(var i in l)
            {
                q.Enqueue(i);
            }

            return temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            Queue<uint> queue = new Queue<uint>();

            StringBuilder sb = new StringBuilder();

            if (T < 1)
                return;
            if (T > 10000)
                return;

            for (int i = 0; i < T; i++)
            {
                string[] command = Console.ReadLine().Split();
                string cm = command[0];

                switch (cm)
                {
                    case "push":
                        queue.Enqueue(uint.Parse(command[1]));
                        break;

                    case "pop":
                        if (queue.Count > 0)
                        {
                            Console.WriteLine(queue.Dequeue().ToString());
                            //sb.Append(queue.Dequeue().ToString()+"\n");
                        }
                        else if (queue.Count == 0)
                            Console.WriteLine("-1");
                        break;

                    case "front":
                        if (queue.Count > 0)
                            Console.WriteLine(queue.Peek().ToString());
                        else if (queue.Count == 0)
                            Console.WriteLine("-1");

                        break;

                    case "back":
                        if (queue.Count > 0)
                            Console.WriteLine(queue.back().ToString());
                        else if (queue.Count == 0)
                            Console.WriteLine("-1");

                        break;

                    case "size":
                        Console.WriteLine(queue.Count.ToString());
                        break;

                    case "empty":
                        if (queue.Count == 0)
                            Console.WriteLine("1");

                        else if (queue.Count > 0)
                            Console.WriteLine("0");

                        break;
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
