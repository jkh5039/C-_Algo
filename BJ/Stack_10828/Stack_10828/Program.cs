using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_10828
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < T; i++)
            {
                string[] command = Console.ReadLine().Split();
                string cm = command[0];
                switch (cm)
                {
                    case "push":
                        stack.Push(int.Parse(command[1]));
                        break;

                    case "pop":
                        if (stack.Count > 0)
                            //Console.WriteLine(stack.Pop().ToString());
                            sb.Append(stack.Pop().ToString()+"\n");
                        else if (stack.Count == 0)
                            //Console.WriteLine("-1");
                            sb.Append("-1"+ "\n");
                        break;

                    case "size":
                        //Console.WriteLine(stack.Count);
                        sb.Append(stack.Count + "\n");
                        break;

                    case "empty":
                        if (stack.Count == 0)
                            //Console.WriteLine("1");
                            sb.AppendLine("1");
                        else if (stack.Count > 0)
                            //Console.WriteLine("0");
                            sb.AppendLine("0");
                            break;

                    case "top":
                        if (stack.Count == 0)
                            //Console.WriteLine("-1");
                            sb.AppendLine("-1");
                        else if (stack.Count > 0)
                            //Console.WriteLine(stack.Peek().ToString());
                            sb.Append(stack.Peek().ToString() + "\n");
                        break;
                }
                
            }
            Console.WriteLine(sb);
        }
    }
}
