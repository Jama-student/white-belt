namespace P09_03Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first integer; ");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine(); 

            Console.Write("Enter the second of integer; ");

            int num1 = Convert.ToInt32(input1);
            int num2 = Convert.ToInt32(input2);

            float result = (float)num1 / num2;
            Console.WriteLine($"Result: {result:F2}");
        }
    }
}
