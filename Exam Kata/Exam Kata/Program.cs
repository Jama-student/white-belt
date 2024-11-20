namespace Examkata;
using System;

class Program
{
    static void Main()
    {
        
        int playerHealth = 80;
        int playerAttack = 15;
        int playerHeal = 10;
        
        int enemyHealth = 50;
        int enemyAttack = 10;

        
        while (playerHealth > 0 && enemyHealth > 0)
        {
            
            Console.WriteLine($"Hero's Health: {playerHealth}");
            Console.WriteLine($"Goblin's Health: {enemyHealth}");

            
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");
            Console.Write("> ");
            string playerChoice = Console.ReadLine();

            
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
                continue; 
            }

            
            if (enemyHealth <= 0)
            {
                Console.WriteLine("Congratulations! Hero has defeated the Goblin!");
                break;
            }

            
            Console.WriteLine("\nGoblin attacks Hero!");
            playerHealth -= enemyAttack;
            Console.WriteLine($"Hero takes {enemyAttack} damage.");

        
            if (playerHealth <= 0)
            {
                Console.WriteLine("Hero has been defeated. Game over!");
                break;
            }
        }
    }
}


