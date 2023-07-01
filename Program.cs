using System;


namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();
        }
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Windows Console Application";
            string appVersion = "1.0.0";
            string appAuthor = "Hassan Bulega";

  
            Console.ForegroundColor = ConsoleColor.Blue;
            
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            
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
    }
}
