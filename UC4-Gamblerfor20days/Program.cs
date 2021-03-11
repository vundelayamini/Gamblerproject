using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using System;

namespace UC4_Gamblerfor20days
{
    class Program
    {
        static void Main(string[] args)
        {       
           public static int stake = 100;
           public static int bet = 1;
           public static int day = 20;
           public static int total20daywin;
           public static int total20daysloose; 
           public static int totalbet20dayWin;
           public static int totalbet20daylose;

        public static void winorLoose(string[] args)
          {
            for (int i = 1; i <= day; i++)
            {
                day--;
                total20daywin += total20daywin;
                total20daysloose += total20daysloose;
                totalbet20dayWin += totalbet20dayWin;
                totalbet20daylose += totalbet20daylose;

            }
            Console.WriteLine("total amount for 20 day win:" + total20daywin);
            Console.WriteLine("total amount for 20 day win: " + total20daysloose);
            Console.WriteLine("total 20 day win bet:" + totalbet20dayWin);
            Console.WriteLine("total 20 losee bet:" + totalbet20daylose);
        }
          public static void winOrLose()
          {
            int dayCost = stake;
            int betCostOnce = bet;
            int totalBetADay = 0;

            while (dayCost != 150 && dayCost != 50)
            {
                Random random = new Random();
                int Check = random.Next(0, 2);
                totalBetADay++;
                if (Check == 1 && betCostOnce == 1)
                {
                    Console.WriteLine("you win");
                    dayCost++;
                    totalbet20dayWin++;
                    total20daywin++;
                    Console.WriteLine("you left cost " + dayCost);
                }
                else
                {
                    Console.WriteLine("you lose");
                    dayCost--;
                    totalbet20daylose++;
                    total20dayloose++;

                    Console.WriteLine("you left cost " + dayCost);
                }

            }


        }

    }
        }
    }
}
