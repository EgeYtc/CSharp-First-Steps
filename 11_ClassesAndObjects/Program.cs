namespace _11_ClassesAndObjects
{
    class Enemy
    {
        public string name;
        private int health = 100;
        public void TakeDamage(int damage)
        {
            health -= damage;
            Console.WriteLine($"{name} took {damage} damage! Remaining health: {health}");
        }


    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Enemy goblin = new Enemy();
            goblin.name = "Sneaky Goblin";

            Enemy boss = new Enemy();
            boss.name = "Orc Warlord";

            goblin.TakeDamage(15);
            boss.TakeDamage(45);


            goblin.TakeDamage(10);

        }
    }
}
