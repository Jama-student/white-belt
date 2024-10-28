using System;

class Program
{
    static void Main(string[] args)
    {
       
        Console.Write("Enter the length of the first side: ");
        float side1 = float.Parse(Console.ReadLine());

        Console.Write("Enter the length of the second side: ");
        float side2 = float.Parse(Console.ReadLine());

       
        float hypotenuse = (float)Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));

     
        Console.WriteLine($"Hypotenuse: {hypotenuse:F2}");
    }
}
