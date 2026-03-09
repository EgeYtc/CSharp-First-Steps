using System;

namespace _15_Abstraction
{
    // 1. The class is now 'abstract'. It cannot be instantiated directly.
    abstract class Enemy
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
                health = 0;
                Console.WriteLine($"{name} has been SLAIN!");
            }
            else
            {
                Console.WriteLine($"{name} took {actualDamage} damage! Remaining health: {health}");
            }
        }

        // 2. The Abstract Method Contract. 
        // It has no curly braces { }. It is just a strict requirement.
        public abstract void PerformAttack();
    }

    // 3. The Derived Classes MUST satisfy the contract
    class Goblin : Enemy
    {
        public Goblin(string name, int health, int armor) : base(name, health, armor) { }

        // The compiler forces the Goblin to implement PerformAttack
        public override void PerformAttack()
        {
            Console.WriteLine($"{name} lunges forward with a rusty dagger, dealing rapid, weak strikes!");
        }
    }

    class Boss : Enemy
    {
        public Boss(string name, int health, int armor) : base(name, health, armor) { }

        // The compiler forces the Boss to implement PerformAttack
        public override void PerformAttack()
        {
            Console.WriteLine($"{name} heaves a massive warhammer, crushing the ground and dealing heavy area damage!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // The compiler will block this line if you try to uncomment it:
            // Enemy generic = new Enemy("Error", 100, 0); 

            Goblin scout = new Goblin("Sneaky Goblin", 30, 0);
            Boss warlord = new Boss("Orc Warlord", 200, 15);

            Console.WriteLine("--- ENEMY PHASE ---");
            scout.PerformAttack();
            warlord.PerformAttack();
        }
    }
}