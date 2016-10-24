using System;
using System.Threading;

namespace PatternGenerator
{
    class SquaredPattern
    {
        public static void SquarePattern()
        {
            Thread.Sleep(1);
            Random randNum = new Random();
            int randElem = randNum.Next(0, 1001);

            for (int lines = 0; lines < 20; lines++)
            {
                for (int i = 0; i < 20; i++)
                {
                    {
                        randElem = randNum.Next(0, 1001);

                        if (randElem % 2 == 0)
                        {
                            Console.Write("--");
                        }
                        else Console.Write("  ");

                    }
                }
                Console.WriteLine();

            }
        }

    }
}
