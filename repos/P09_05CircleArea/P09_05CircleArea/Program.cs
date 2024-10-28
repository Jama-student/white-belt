using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter the radius: ");
        float radius = float.Parse(Console.ReadLine());

       
        float area = (float)(Math.PI * Math.Pow(radius, 2));

        
        Console.WriteLine($"Area of the circle: {area:F2}");
    }
}
