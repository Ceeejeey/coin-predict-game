using System;

class Program
{
    static void Main()
    {
        // Generate a random choice for head or tail
        Random choice = new Random();
        int headOrTail = choice.Next(0, 2);

        // Convert the random choice to a string representation
        string systemChoice = headOrTail == 0 ? "head" : "tail";

        // Ask the user for their choice
        Console.Write("Enter your choice ('head' or 'tail'): ");
        string userChoice = Console.ReadLine();

        // Determine the result
        string result = userChoice.Equals(systemChoice, StringComparison.OrdinalIgnoreCase) ? "You won!" : "Bad luck today.";

        // Display the result
        Console.WriteLine($"Result is {systemChoice}. {result}");
    }
}
