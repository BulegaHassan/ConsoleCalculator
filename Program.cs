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

                    Console.Write("Enter the operation sign; + or - or * or / or %: ");
                    // int operation = Convert.ToInt32(Console.ReadLine());
                    string operation = Console.ReadLine();
                    Console.Write("Enter the second number: ");
                    int number2 = Convert.ToInt32(Console.ReadLine());

                   /* Console.WriteLine("1 - Addition");
                    Console.WriteLine("2 - Subtraction");
                    Console.WriteLine("3 - Multiplication");
                    Console.WriteLine("4 - Division");
                    Console.WriteLine("5 - Remainder");
                    Console.WriteLine("6 - Exit");
                    */

                    double result = 0;
                    switch (operation)
                    {
                        case "+":
                            result = number1 + number2;
                            
                            PrintColorMessage(ConsoleColor.Green, "Result: " + result);
                            break;
                        case "-":
                            result = number1 - number2;
                            PrintColorMessage(ConsoleColor.Green, "Result: " + result);
                            break;
                        case "*":
                            result = number1 * number2;
                            PrintColorMessage(ConsoleColor.Green, "Result: " + result);
                            break;
                        case "/":
                            if (number2 != 0)
                            {
                                result = (double)number1 / number2;
                                PrintColorMessage(ConsoleColor.Green, "Result: " + result);
                            }
                            else
                            {
                                PrintColorMessage(ConsoleColor.Red, "Cannot divide by zero");
                            }
                            break;
                        case "%":
                            result = number1 % number2;
                            PrintColorMessage(ConsoleColor.Green, "Result: " + result);
                            break;
                        case "q":
                            exit = true;
                            break;
                        default:
                            PrintColorMessage(ConsoleColor.DarkRed, "Invalid operation number");

                            break;
                    }

                }
                catch (Exception ex)
                {
                            PrintColorMessage(ConsoleColor.Red, "An error occured" +ex);
                }
            }
        }
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Windows Console Calculator Application";
            string appVersion = "1.0.0";
            string appAuthor = "Hassan Bulega";

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.WriteLine("**************************************************************************");

            Console.ResetColor();
        }
        static void GreetUser()
        {            
            Console.WriteLine("What is your name?");
            
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Welcome to our Calculator its Maths time...", inputName);
        }
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            
            Console.ForegroundColor = color;            
            Console.WriteLine(message);            
            Console.ResetColor();
        }
    }
}
