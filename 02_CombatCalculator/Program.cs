namespace _02_CombatCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseDamage = 35;
            Console.WriteLine("Enter a combo multiplier: ");
            string userInput = Console.ReadLine();
            int damage = (int)(double.Parse(userInput)*baseDamage);
            Console.WriteLine($"HIT! {damage}");
            
        }
    }
}
