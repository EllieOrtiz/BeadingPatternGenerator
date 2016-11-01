using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PatternGenerator
{
    class SecondSquarePattern : BasePattern
    {
        public override void CreatePattern()
        {
            Thread.Sleep(1);
            Random randNum = new Random();
            int randElem = randNum.Next(0, 1001);
            StringBuilder sb = new StringBuilder();

            //generates a random line
            for (int lines = 0; lines < 20; lines++)
            {
                //generates 20 random lines
                for (int i = 0; i < 20; i++)
                {
                    randElem = randNum.Next(0, 1001);

                    if (randElem % 2 == 0 && randElem < 500)
                    {
                        Console.Write("--");
                        sb.Append("--");
                    }
                    else
                    {
                        Console.Write("  ");
                        sb.Append("  ");
                    }
                }
                Console.WriteLine();
                sb.Append("\n");

            }//option to save the pattern
            this.value = sb.ToString();
        }

    }
}
