using System;
using System.Threading;

namespace PatternGenerator
{
    class OneLinePattern
    {
        public static void OneLine()
        {
            Thread.Sleep(1);
            Random randNum = new Random();
            int randElem = randNum.Next(0, 1001);
                       
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
            
        }
    }
}
