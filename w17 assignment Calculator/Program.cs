using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace w17_assignment_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int delay = 1000, rePlay=0;
            double Nr1, Nr2, myResult;
            string Choice;
            bool again=false, valid=false;
            
            Console.WriteLine("Welcome to the calculator wizard!");
            Thread.Sleep(delay);
            Console.WriteLine("Let's do some calculations!");
            Thread.Sleep(delay);
            Console.WriteLine("You choose two numbers and an operator and I'll give you the result.");
            Thread.Sleep(delay);

            do
            {
                do                                              //- Checking number 1
                {
                    Console.Write("Choose Number 1: ");
                    Choice = Console.ReadLine();
                    valid = Double.TryParse(Choice, out Nr1);   //- Validation
                    if (valid == false)
                    {
                        Console.WriteLine("Tha was NOT a number! Try again!");
                    }
                }
                while (valid == false);

                do                                              //- Checking number 2
                {
                    Console.Write("Choose Number 2: ");
                    Choice = Console.ReadLine();
                    valid = Double.TryParse(Choice, out Nr2);   //- Validation
                    if (valid == false)
                    {
                        Console.WriteLine("Man, you can do better! Try again!");
                    }
                }
                while (valid == false);

                Console.WriteLine("Nice! What should we do with them?");
                Thread.Sleep(delay);
                Console.WriteLine();
                Console.WriteLine("   Press \"+\" for addition");
                Console.WriteLine("\t \"-\" for subtraction");
                Console.WriteLine("\t \"*\" for multiplication");
                Console.WriteLine("\t \"/\" for division");

                do
                {
                    valid = false;
                    Console.Write("Choose the operation!");
                    Choice = Console.ReadLine();

                    switch (Choice)                             //- Checking operation choice
                    {
                        case "+":
                            myResult = Nr1 + Nr2;
                            Announce(myResult);
                            valid = true;
                            break;
                        case "-":
                            myResult = Nr1 - Nr2;
                            Announce(myResult);
                            valid = true;
                            break;
                        case "*":
                            myResult = Nr1 * Nr2;
                            Announce(myResult);
                            valid = true;
                            break;
                        case "/":
                            myResult = Nr1 / Nr2;
                            Announce(myResult);
                            valid = true;
                            break;

                        default:                                //- Checking failed
                            Console.WriteLine("Man, Seriously? Try again!");
                            break;
                    }
                }
                while (valid == false);

                rePlay++;

                Thread.Sleep(delay);
                if (rePlay == 1)
                {
                    Console.WriteLine("That was fun! One more time!");
                    again = true;
                }
                else if (rePlay >= 2)
                {
                    if (rePlay == 2)
                    {
                        Console.Write("We just warmed up! Do you wanna play again? (Y/N)");
                    }
                    else
                    {
                        Console.Write("One more time? (Y/N)");
                    }
                    Choice = Console.ReadLine();
                    Choice = Choice.ToUpper();
                    if (Choice == "Y")
                    {
                        Console.WriteLine("That's the spirit!");
                        again = true;
                    }
                    else if (Choice == "N")
                    {
                        Console.Write("That's ... ");
                        Thread.Sleep(delay);
                        Console.WriteLine("disappointing...");
                        Thread.Sleep(delay);
                        Console.Write("But it was nice. ");
                        Thread.Sleep(delay);
                        Console.WriteLine("As long as it lasted ....");
                        Thread.Sleep(delay);
                        Console.WriteLine("Bye!");

                        again = false;
                    }
                }
            }
            while (again);
        }    
        
        static void Announce(double result)
        {
            Console.WriteLine("And the result is: " + result);
        }


        
    }
    
    
}
