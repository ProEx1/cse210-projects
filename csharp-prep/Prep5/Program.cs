using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int numberSquared = SquareNumber(userNumber);
        DisplayResult(userName, numberSquared);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favourite number: ");
            String userNumberString = Console.ReadLine();
            int userNumber = int.Parse(userNumberString);
            return userNumber; 
        }

        static int SquareNumber(int userNumber)
        {
            int numberSquared = (userNumber * userNumber);
            return numberSquared;
        }
        static void DisplayResult(string userName, int numberSquared)
        {
            Console.WriteLine($"{userName}, the square of your number is {numberSquared}");
        }

        


    }
}