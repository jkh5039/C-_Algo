using System;
using System.Collections.Generic;
namespace Queue_10845
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            List<int> queue = new List<int>();
            for (int i = 0; i < T; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "push")
                {
                    queue.Add(int.Parse(command[1]));
                }

                else if (command[0] == "pop")
                {
                    if (queue.Count > 0)
                    {
                        Console.WriteLine(queue[0]);
                        queue.Remove(queue[0]);

                    }

                    else if (queue.Count == 0)
                    {
                        Console.WriteLine(-1);
                        continue;
                    }
                }

                else if (command[0] == "size")
                {
                    Console.WriteLine(queue.Count);
                }

                else if (command[0] == "empty")
                {
                    if (queue.Count == 0)
                        Console.WriteLine(1);
                    else if (queue.Count > 0)
                        Console.WriteLine(0);

                }

                else if (command[0] == "front")
                {
                    if (queue.Count > 0)
                        Console.WriteLine(queue[0]);
                    else if (queue.Count == 0)
                        Console.WriteLine(-1);

                }

                else if (command[0] == "back")
                {
                    if (queue.Count > 0)
                        Console.WriteLine(queue[queue.Count - 1]);
                    else if (queue.Count == 0)
                        Console.WriteLine(-1);

                }
            }
        }
    }
}
