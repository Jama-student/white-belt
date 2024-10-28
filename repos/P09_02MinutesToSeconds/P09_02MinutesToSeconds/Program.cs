namespace P09_02MinutesToSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Minutes;");
            
            string input = Console.ReadLine();

            int minutes = Convert.ToInt32(input);

            int seconds = minutes * 60;
            Console.WriteLine($"Seconds: {seconds}");
        }
    }
}
