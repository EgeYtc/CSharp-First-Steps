namespace _14_Polymorphism
{
    class Enemy
    {
        public string name;
        protected int health;
        protected int armor;

        public Enemy(string startingName, int startingHealth, int startingArmor)
        {
            name = startingName;
            health = startingHealth;
            armor = startingArmor;
        }

        public virtual void TakeDamage(int incomingDamage)
        {
            int actualDamage = Math.Max(0, incomingDamage - armor);

            health -= actualDamage;
            if (health <= 0)
            {
                health = 0; // Clamps the health to exactly zero
                Console.WriteLine($"{name} took {actualDamage} damage and has been SLAIN!");
            }
            else
            {
                Console.WriteLine($"{name} took {actualDamage} damage (Armor blocked {armor})! Remaining health: {health}");
            }
        }
    }
    class Boss : Enemy
    {
        public Boss(string name, int health, int armor) : base(name, health, armor)
        {

        }

        public override void TakeDamage(int incomingDamage)
        
        {
            if (health <= 50)
            {
                armor += 20;
                Console.WriteLine($"\nWARNING: {name} becomes enraged! Armor drastically increased!");
            }
            else
            {
                base.TakeDamage(incomingDamage);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Enemy goblin = new Enemy("Sneaky Goblin", 50, 0);

            Boss warlord = new Boss("Orc Warlord", 100, 5);

            Console.WriteLine("--- BATTLE START ---");

            goblin.TakeDamage(30);
            warlord.TakeDamage(60);

            Console.WriteLine("\nPlayer unleashes a massive combo attack!");

            goblin.TakeDamage(30);

            warlord.TakeDamage(30);

            




        }
    }
}

