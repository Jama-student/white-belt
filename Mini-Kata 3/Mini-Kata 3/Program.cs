namespace MiniKata4;
using System;
class Program
{
    static void Main()
    {
        
        int playerLuck = 7;

        
        Console.WriteLine("Do you want to attack the enemy? (yes/no)");
        string playerChoice = Console.ReadLine().ToLower();

        if (playerChoice == "yes")
        {
            
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
