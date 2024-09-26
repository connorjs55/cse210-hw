using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1,101);

        int response = -1;

        while (response != randomNumber)
        {
        
        Console.Write("What is the magic number? ");
        response = int.Parse((Console.ReadLine()));

        if (response == randomNumber)
        {
            Console.WriteLine("Congratulations, you guessed it! ");
        }
        else if (response > randomNumber)
        {
            Console.WriteLine("Lower ");
        }
        else if (response < randomNumber)
        {
            Console.WriteLine("Higher ");
        }
        else
        {
            Console.WriteLine("Error, please try again.");
        }
        }
    }
}

// {
//     static void Main(string[] args)
//     {

//         Random randomGenerator = new Random();
//         int randomNumber = randomGenerator.Next(1,101);

//         string response = "";

//         while (response != "14")
//         {
        
//         Console.Write("What is the magic number? ");
//         response = Console.ReadLine();
//         int number = int.Parse(response);

//         if (number == 14)
//         {
//             Console.WriteLine("Congratulations, you guessed it! ");
//         }
//         else if (number > 14)
//         {
//             Console.WriteLine("Lower ");
//         }
//         else if (number < 14)
//         {
//             Console.WriteLine("Higher ");
//         }
//         else
//         {
//             Console.WriteLine("Error, please try again.");
//         }
//         }
//     }