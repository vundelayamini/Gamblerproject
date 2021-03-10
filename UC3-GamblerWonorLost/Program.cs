using System;

namespace UC3_GamblerWonorLost
{
    class Program
    {
        public const int snake = 100;
        public const int bet = 1;
        public const int win = 0;
        public const int loss = 0;
        public static void Main(string[] args)
        {
            while (win < 50 && loss < 50)
            {
                Random random = new Random();
                int checkVal = random.Next(0, 2);
                if (checkVal == 1)
                {
                    Console.WriteLine("player won");
                }
                else
                {
                    Console.WriteLine("player loss");

                }


            }
        }
    }
}
