namespace P8Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me number.");
            String userInput = Console.ReadLine();

            float floatNumber =float.Parse(t);
            Console.WriteLine(floatNumber);

            int intFromDouble = (int)floatNumber;  
            Console.WriteLine(intFromDouble);

            int intFromString = int.Parse (userInput);
        }
    }
}
