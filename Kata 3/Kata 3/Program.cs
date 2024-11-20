namespace kata3;
using System;

class Program
{
    static void Main()
    {
        
        int playerLuck = 7;

        
        Console.WriteLine("You find a mysterious treasure chest! What will you do?");
        Console.WriteLine("1. Open the chest");
        Console.WriteLine("2. Ignore the chest");
        Console.WriteLine("3. Leave the area");
        Console.Write("> ");

        
        string choice = Console.ReadLine();

        
        if (choice == "1")
        {
            Console.WriteLine("You try to open the chest...");
            if (playerLuck > 7)
            {
                Console.WriteLine("Success! The chest contains a rare gem.");
            }
            else if (playerLuck >= 5)
            {
                Console.WriteLine("You find some gold.");
            }
            else
            {
                Console.WriteLine("The chest was trapped!");
            }
        }
        else if (choice == "2")
        {
            Console.WriteLine("You decide to ignore the chest and continue on your journey.");
        }
        else if (choice == "3")
        {
            Console.WriteLine("You leave the area, and the mystery remains unsolved.");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please choose 1, 2, or 3.");
        }
    }
}

