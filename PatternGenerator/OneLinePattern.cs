using System;
using System.Text;
using System.Threading;

namespace PatternGenerator
{
    class OneLinePattern : BasePattern
    {
        public override void CreatePattern()
        {
            Thread.Sleep(1);
            Random randNum = new Random();
            int randElem = randNum.Next(0, 1001);
            StringBuilder sb = new StringBuilder();
            //generates one random line  
            for (int i = 0; i < 20; i++)
            {
                randElem = randNum.Next(0, 1001);

                if (randElem % 2 == 0)
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
            this.value = sb.ToString();
            
        }
    }
}
