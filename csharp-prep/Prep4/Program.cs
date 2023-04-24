using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type '0' when finished.");
        int inputNumber = -1;
        List<int> numbers = new List<int>();
        while (inputNumber != 0)
        {
            Console.Write("Enter number: ");
            string inputString = Console.ReadLine();
            inputNumber = int.Parse(inputString);

            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}" );

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average} ");

        int largestNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }
        Console.WriteLine($"The largest number is: {largestNumber} ");
    }
}