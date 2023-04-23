using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // Console.Write("What is the magic number? ");
        // string strNumber = Console.ReadLine();
        // int number = int.Parse(strNumber);
        string response;

        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1,100);
            int guess = -1;
            int tries = 0;

            while (guess != number)
                {Console.Write("What is your guess? ");
                string strGuess = Console.ReadLine();
                guess = int.Parse(strGuess);
                tries++;
                

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }

                if (guess == number)
                {
                    Console.WriteLine("You guessed it!");
                }
                }
            Console.WriteLine($"You took {tries} tries. ");
            Console.Write("Do you wish to continue? (yes/no) ");
            response = Console.ReadLine();
        } while (response == "yes" || response == "Yes");



        }
}