using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string inputName = PromptUserName();
        int inputNumber = PromptUserNumber();
        int numberSquared = SquareNumber(inputNumber);
        DisplayResult(inputName, numberSquared);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program! ");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string favoriteNumber = Console.ReadLine();
            int numberToSquare = int.Parse(favoriteNumber);
            return numberToSquare;
        }

        static int SquareNumber(int numberToSquare)
        {
            int squaredNumber = numberToSquare * numberToSquare;
            return squaredNumber;
        }

        static void DisplayResult(string name, int squaredNumber)
        {
            Console.WriteLine($"Ok {name}, when we square your favorite number, we get {squaredNumber}.");
        }
    }
}