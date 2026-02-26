namespace _03_LootDrop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. We create our "dice roller" machine using the green Random class
            Random diceRoller = new Random();

            // 2. We tell the machine to pick a number between 1 and 100. 
            // (Note: C# includes the first number, but EXCLUDES the last number, so we write 101 to get up to 100)
            int roll = diceRoller.Next(1, 101);

            Console.WriteLine($"You defeated an enemy! The loot dice rolled a: {roll}");
            Console.WriteLine("Searching the body...");

            // 3. The If/Else Bouncer Logic
            if (roll >= 100)
            {
                Console.WriteLine("You got the MYTHIC CROWN!");
            }
            else if (roll >= 90)
            {
                // This only happens if they roll 90 to 100 (A 10% chance)
                Console.WriteLine("AMAZING! You found the Legendary Red Sword!");
            }
            else if (roll >= 50)
            {
                // If they didn't get 90+, but got 50 to 89 (A 40% chance)
                Console.WriteLine("Nice! You found a Health Potion.");
            }
            
            else
            {
                // If ALL of the above were false (A 50% chance)
                Console.WriteLine("Bad luck. You found a rusty coin.");
            }
        }
    }
}
