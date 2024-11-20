namespace MiniKata2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string name = "Jack";
            int healthPoints = 100;
            float attackPower = 15.5f;
            double expPoints = 250.234;
            bool isParalyzed = true;
            string goldCoins = "150,1";

            
            double doubleHealth = healthPoints;

        
            int intAttackPower = (int)attackPower;

        
            int convertedExpPoints = Convert.ToInt32(expPoints);

            
            if (int.TryParse(goldCoins, out int parsedGoldCoins))
            {
                Console.WriteLine(parsedGoldCoins);
            }
            else
            {
                Console.WriteLine("The parse is invalid!");
            }

            
            Console.WriteLine($"{name}");
            Console.WriteLine($"{doubleHealth}");
            Console.WriteLine($"{intAttackPower}");
            Console.WriteLine($"{convertedExpPoints}");
        }
    }
}
