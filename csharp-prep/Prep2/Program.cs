using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        string letterGrade = "";
        string sign = "";
        int signTest = (gradePercentage % 10);
            if (signTest >= 7)
            {
                sign = "+";
            }
            if (signTest < 3)
            {
                sign = "-";
            }

        if (gradePercentage >= 90)
        {
            letterGrade = "A";           
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (letterGrade == "A" && sign == "+" || letterGrade == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your letter grade is: {letterGrade}{sign} ");

        if (letterGrade == "D" || letterGrade == "F")
        {
            Console.WriteLine("You've come far, but please keep trying. ");
        }
        else
        {
            Console.WriteLine("You are passing, congrats, keep pushing! ");
        }

    
    }
}