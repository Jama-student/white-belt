namespace Examkata;
using System;

class Program
{
    static void Main()
    {
        // Initialize player and enemy stats
        int playerHealth = 80;
        int playerAttack = 15;
        int playerHeal = 10;
        
        int enemyHealth = 50;
        int enemyAttack = 10;

        // Main game loop
        while (playerHealth > 0 && enemyHealth > 0)
        {
            // Display current health
            Console.WriteLine($"Hero's Health: {playerHealth}");
            Console.WriteLine($"Goblin's Health: {enemyHealth}");

            // Prompt the player for an action
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");
            Console.Write("> ");
            string playerChoice = Console.ReadLine();

            // Player's action
            if (playerChoice == "1")
            {
                Console.WriteLine("Hero attacks the Goblin!");
                enemyHealth -= playerAttack;
                Console.WriteLine($"Goblin takes {playerAttack} damage.");
            }
            else if (playerChoice == "2")
            {
                Console.WriteLine("Hero heals!");
                playerHealth += playerHeal;
                Console.WriteLine($"Hero gains {playerHeal} health.");
            }
            else
            {
                Console.WriteLine("Invalid choice! Please choose 1 or 2.");
                continue; // Skip enemy attack if invalid input
            }

            // Check if the enemy or player has lost
            if (enemyHealth <= 0)
            {
                Console.WriteLine("Congratulations! Hero has defeated the Goblin!");
                break;
            }

            // Enemy's attack
            Console.WriteLine("\nGoblin attacks Hero!");
            playerHealth -= enemyAttack;
            Console.WriteLine($"Hero takes {enemyAttack} damage.");

            // Check if the player has lost
            if (playerHealth <= 0)
            {
                Console.WriteLine("Hero has been defeated. Game over!");
                break;
            }
        }
    }
}


