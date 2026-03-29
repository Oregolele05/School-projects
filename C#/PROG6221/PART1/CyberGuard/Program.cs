using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

class Cybersecurity()
{
    public static void Main(string[] args)
    {
       
    }
    //this is for the voice greeting which will greet the user when the application launches
    public static void VoiceGreeting()
    {

    }
    //this is for the logo which will dispay when application runs
    public static void LogoDisplay()
    {
        Console.WriteLine("  ██████╗██╗   ██╗██████╗ ███████╗██████╗  ██████╗ ██╗   ██╗ █████╗ ██████╗ ██████╗ \r\n ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗██╔════╝ ██║   ██║██╔══██╗██╔══██╗██╔══██╗\r\n ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝██║  ███╗██║   ██║███████║██████╔╝██║  ██║\r\n ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗██║   ██║██║   ██║██╔══██║██╔══██╗██║  ██║\r\n ╚██████╗   ██║   ██████╔╝███████╗██║  ██║╚██████╔╝╚██████╔╝██║  ██║██║  ██║██████╔╝\r\n  ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝ ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═════╝ ");
    }
    //this is for the user when they are asked for an nput such as their name
    public static void UserInteraction()
    {
        while (true)
        {
            //this is for the text colour
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            //ask user for their name
            Console.Write("What is your name: ");
            string name = Console.ReadLine().Trim();

            //this code will validate the user input for name
            if (name.IsWhiteSpace())
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Please enter a valid name.");
                continue;
            }
            else if (name.Any(char.IsDigit))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("A name cannot contain numeric values.");
                continue;
            }
            Console.WriteLine("welcome " + name + " nice to meet you!!\n");
            break;
        }
    }
    //this is for the chatbot response system which will respond to the user input
    public static void ResponseSystem()
    {

    }

}