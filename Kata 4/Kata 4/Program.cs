namespace kata4;
using System;

using System.Threading;

class Program
{
    static void Main()
    {
        // Number of waves and enemies per wave
        int totalWaves = 3;
        int enemiesPerWave = 4;

        // Loop through each wave
        for (int wave = 1; wave <= totalWaves; wave++)
        {
            // Display the start of the wave
            Console.WriteLine($"Wave {wave} is starting!");

            // Inner loop to spawn enemies in the wave
            for (int enemy = 1; enemy <= enemiesPerWave; enemy++)
            {
                // Display each enemy spawned
                Console.WriteLine($"  Enemy #{enemy} has spawned.");
            }

            // Display the end of the wave
            Console.WriteLine($"Wave {wave} completed. Preparing for the next wave...");

            // Pause for a short delay (1 second) between waves
            Thread.Sleep(1000);  // 1000 milliseconds = 1 second
        }

        // Display the victory message after all waves are completed
        Console.WriteLine("All waves completed! Victory is yours!");
    }
}

    

