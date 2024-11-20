namespace Minikata4;
using System;


class Program
{
    static void Main()
    {
        
        Console.WriteLine("Spawning enemies using a for loop:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Enemy #{i} spawned!");
        }

        
        Console.WriteLine("\nSpawning enemies using a while loop:");
        int enemiesSpawned = 0;
        while (enemiesSpawned < 3)
        {
            enemiesSpawned++;
            Console.WriteLine($"Enemy #{enemiesSpawned} spawned!");
        }
    }
}

