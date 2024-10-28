using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter weight in kg: ");
        float weight = float.Parse(Console.ReadLine());

        Console.Write("Enter height in meters: ");
        float height = float.Parse(Console.ReadLine());

       
        float bmi = weight / (height * height);

        
        Console.WriteLine($"BMI: {bmi:F2}");
    }
}
