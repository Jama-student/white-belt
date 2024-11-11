namespace minikata2;

using System;
class Program
{
    static void Main()
    {
        // Declare and initialize character attributes with different data types
        string name = "Lira";
        int level = 5;
        float healthPoints = 75.5f;
        double experiencePoints = 1025.75;
        bool magicAbility = true;
        char rank = 'A';

        // Calculate the points needed for the next level (example calculation)
        double pointsForNextLevel = 2000 - experiencePoints; // Assuming next level is at 2000 experience points

        // Display each attribute and its value
        Console.WriteLine($"Character Name: {name}");
        Console.WriteLine($"Level: {level}");
        Console.WriteLine($"Health Points: {healthPoints}");
        Console.WriteLine($"Experience Points: {experiencePoints}");
        Console.WriteLine($"Has Magic Ability: {magicAbility}");
        Console.WriteLine($"Rank: {rank}");
        Console.WriteLine($"Points needed to reach next level: {pointsForNextLevel:F2}");
    }
}


