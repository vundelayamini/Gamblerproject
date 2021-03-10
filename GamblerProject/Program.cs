using System;

namespace GamblerProject
{
    class Program
    {
            static void Main(string[] args)
            {
                int snake = 100;
                int bet = 1
               Random random = new Random();
                int checkVal = Random.Next(0, 2);
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
