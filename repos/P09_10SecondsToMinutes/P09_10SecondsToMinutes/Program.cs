using System;

class Program
{
    static void Main(string[] args)
    {
      
        Console.Write("Enter seconds: ");
        int totalSeconds = Convert.ToInt32(Console.ReadLine());

       
        int minutes = totalSeconds / 60;
        int seconds = totalSeconds % 60;

         Console.WriteLine($"{minutes} minute(s) and {seconds} second(s)");
    }
}
