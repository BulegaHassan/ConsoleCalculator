using System;


namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
           
            bool exit = false;
            GetAppInfo();
            GreetUser();
            while(!exit)
            {
                try
                {
                    Console.Write("Enter the first number: ");
                    int number1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    int number2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("1 - Addition");
                    Console.WriteLine("2 - Subtraction");
                    Console.WriteLine("3 - Multiplication");
                    Console.WriteLine("4 - Division");
                    Console.WriteLine("5 - Remainder");
                    Console.WriteLine("6 - Exit");

                    Console.Write("Enter the operation number: ");
                    int operation = Convert.ToInt32(Console.ReadLine());

                    double result = 0;
                    switch (operation)
                    {
                        case 1:
                            result = number1 + number2;
                            //Console.WriteLine("Result: " + result);
                            PrintColorMessage(ConsoleColor.Green, "Result: " + result);
                            break;
                        case 2:
                            result = number1 - number2;
                            Console.WriteLine("Result: " + result);
                            break;
                        case 3:
                            result = number1 * number2;
                            Console.WriteLine("Result: " + result);
                            break;
                        case 4:
                            if (number2 != 0)
                            {
                                result = (double)number1 / number2;
                                Console.WriteLine("Result: " + result);
                            }
                            else
                            {
                                Console.WriteLine("Division by zero is not allowed.");
                            }
                            break;
                        case 5:
                            result = number1 % number2;
                            Console.WriteLine("Result: " + result);
                            break;
                        case 6:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid operation number.");
                            break;
                    }

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Windows Console Application";
            string appVersion = "1.0.0";
            string appAuthor = "Hassan Bulega";

  
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("************************************************************");
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.WriteLine("************************************************************");

            Console.ResetColor();
        }
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Welcome to our Calculator its maths time...", inputName);
        }
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
