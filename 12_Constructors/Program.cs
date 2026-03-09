namespace _12_Constructors
{

    class Enemy
    {
        public string name;
        private int health;
        private int armor;

        public Enemy(string startingName, int startingHealth, int startingArmor)
        {
            name = startingName;
            health = startingHealth;
            armor = startingArmor;
        }

        public void TakeDamage(int incomingDamage)
        {
            int actualDamage = Math.Max(0, incomingDamage - armor);

            health -= actualDamage;
            Console.WriteLine($"{name} took {actualDamage} damage (Armor blocked {armor})! Remaining health: {health}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Enemy goblin = new Enemy("Sneaky Goblin", 100, 0);
            Enemy boss = new Enemy("Orc Warlord", 100, 15);

            Console.WriteLine("Player attacks for 20 damage!");

            goblin.TakeDamage(20);
            boss.TakeDamage(20);   
        }
    }
}
