namespace MiniKata2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            string name = "Jack";
            int healthPoints = 100;
            float attackPower = 15.5f;
            double expPoints = 250.234;
            bool isParalyzed = true;
            string goldCoins = "150,1";

            // Implicit conversion (int to double)
            double doubleHealth = healthPoints;

            // Explicit conversion (float to int)
            int intAttackPower = (int)attackPower;

            // Using Convert class
            int convertedExpPoints = Convert.ToInt32(expPoints);

            // Safe conversion using TryParse
            if (int.TryParse(goldCoins, out int parsedGoldCoins))
            {
                Console.WriteLine(parsedGoldCoins);
            }
            else
            {
                Console.WriteLine("The parse is invalid!");
            }

            // Output results
            Console.WriteLine($"{name}");
            Console.WriteLine($"{doubleHealth}");
            Console.WriteLine($"{intAttackPower}");
            Console.WriteLine($"{convertedExpPoints}");
        }
    }
}
