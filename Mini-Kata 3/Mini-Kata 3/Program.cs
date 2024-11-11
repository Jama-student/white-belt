namespace MiniKata4;
using System;
class Program
{
    static void Main()
    {
        // Declare a playerLuck variable between 1 and 10
        int playerLuck = 7;

        // Ask the player if they want to attack
        Console.WriteLine("Do you want to attack the enemy? (yes/no)");
        string playerChoice = Console.ReadLine().ToLower();

        if (playerChoice == "yes")
        {
            // Check attack success based on playerLuck
            if (playerLuck > 7)
            {
                Console.WriteLine("Success! Your attack hits the enemy.");
            }
            else if (playerLuck >= 6)
            {
                Console.WriteLine("Barely succeeded. Your attack hits the enemy.");
            }
            else
            {
                Console.WriteLine("Attack missed!");
            }
        }
        else
        {
            Console.WriteLine("You chose to retreat.");
        }
    }
}