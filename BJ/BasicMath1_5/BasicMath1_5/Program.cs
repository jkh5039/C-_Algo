using System;

namespace BasicMath1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int T = int.Parse(Console.ReadLine());
            
            for(int i=0; i<T; i++)
            {

                string[] Hotel = Console.ReadLine().Split();
                int H = int.Parse(Hotel[0]); //~99
                int W = int.Parse(Hotel[1]); //~99
                int customer = int.Parse(Hotel[2]);

                //층수 알려준다
                int Layer = customer % H;
                

                int room = customer / H;
                room += 1;
                if (Layer == 0)
                {
                    //제일 꼭대기층 
                    Layer = H;
                    room -= 1;
                }
                string Layer1 =Layer.ToString();
                string room1 = room.ToString("D2");
                

                Console.WriteLine(Layer1+room1);
            }
            
            
            

        }
    }
}
