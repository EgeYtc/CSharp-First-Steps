namespace _13_Inheritance
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

        public void TakeDamage(int incomingDamage)
        {
            int actualDamage = Math.Max(0, incomingDamage - armor);

            health -= actualDamage;
            Console.WriteLine($"{name} took {actualDamage} damage (Armor blocked {armor})! Remaining health: {health}");
        }
    }
    class Boss : Enemy
        {
            public Boss (string name, int health, int armor) : base(name, health, armor)     
            {
                
            }

            public void CheckPhaseTwo()
            {
                if (health <= 50)
                {
                    armor += 20;
                    Console.WriteLine($"\nWARNING: {name} becomes enraged! Armor drastically increased!");
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

            warlord.CheckPhaseTwo();



            
        }
    }
}
