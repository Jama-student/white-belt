namespace minikata2;

using System;
class Program
{
    static void Main()
    {
        
        string name = "Lira";
        int level = 5;
        float healthPoints = 75.5f;
        double experiencePoints = 1025.75;
        bool magicAbility = true;
        char rank = 'A';

        
        double pointsForNextLevel = 2000 - experiencePoints; 

        
        Console.WriteLine($"Character Name: {name}");
        Console.WriteLine($"Level: {level}");
        Console.WriteLine($"Health Points: {healthPoints}");
        Console.WriteLine($"Experience Points: {experiencePoints}");
        Console.WriteLine($"Has Magic Ability: {magicAbility}");
        Console.WriteLine($"Rank: {rank}");
        Console.WriteLine($"Points needed to reach next level: {pointsForNextLevel:F2}");
    }
}


