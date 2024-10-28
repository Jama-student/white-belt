namespace P09_01SpeedConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
         Console.Write("Enter speed in km/h:");
         string input = Console.ReadLine();

         double kmh = Convert.ToDouble(input);

         double ms = kmh / 3.6;
         Console.WriteLine("Speed in m/s: " + ms.ToString("F2"));


        }
    }
}
