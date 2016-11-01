using System;

namespace PatternGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            //Call the SquaredPattern class to generate a squared random pattern
            SquaredPattern squarePattern1 = new SquaredPattern();
            squarePattern1.CreatePattern();
            Console.WriteLine("\n\n");

            //OneLinePattern linepattern1 = new OneLinePattern();
            //linepattern1.CreatePattern();

            SecondSquarePattern secondSPattern1 = new SecondSquarePattern();
            secondSPattern1.CreatePattern();

            //Gives to user the option of saving the generated pattern
            Console.WriteLine("Do you want to save this pattern?");
            string answer = Console.ReadLine();

            //in case where the user writes yes, the SavePattern class is called
            if (answer.ToLower() == "yes" )
            {
                secondSPattern1.Save();
               
                secondSPattern1.Save();

            }
            else
            {
                //under construction
                Console.WriteLine("would you like to generate new pattern?");
            }
        }

    }
    
}
     
   