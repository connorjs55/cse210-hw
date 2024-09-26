using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentageInput = Console.ReadLine();
        int percentage = int.Parse(percentageInput);
        
        string letter = "";

        if (percentage >= 90) 
        {
            letter = "A";
        }
        else if (percentage >= 80 && percentage < 90)
        {
            letter = "B";
        }
        else if (percentage >= 70 && percentage < 80)
        {
            letter = "C";
        }
        else if (percentage >= 60 && percentage < 70)
        {
            letter = "D";
        }
        else if (percentage < 60)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("Input error, please try again.");
        }

        Console.WriteLine($"The grade you got is {letter}. ");
        
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed! ");
        }
        else if (percentage < 70)
        {
            Console.WriteLine("Sorry, you did not pass. Please try again. ");
        }
        else
        {
            Console.WriteLine("Input error, please try again. ");
        }
    }
}