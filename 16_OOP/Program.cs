using System.Runtime.CompilerServices;
using System.Threading;

namespace _16_OOP
{

    class SupplyCache
    {
        private int rations;
        private int firewood;

        public SupplyCache(int startingRations, int startingFirewood)
        {
            rations = startingRations;
            firewood = startingFirewood;
           
        }

        public bool TryConsume(int requestedRations, int requestedFirewood)
        {
            if (rations >= requestedRations && firewood >= requestedFirewood)
            {
                rations -= requestedRations;
                firewood -= requestedFirewood;
                return true;
            }

            return false;
        }

        public void PrintStatus()
        {
            Console.WriteLine($"Total supply left rations: {rations} and firewood: {firewood}");
        }


    }

    abstract class Consumers
    {
        public string type;
        protected int requiredRations;
        protected int requiredFirewood;
        protected int health;

        public Consumers(string typeOfConsumer, int reqFood, int reqWood)
        {
            type = typeOfConsumer;
            requiredRations = reqFood;
            requiredFirewood = reqWood;
            health = 100;
        }

        public void CheckHealth()
        {
            int currentHealth = health;
            Console.WriteLine($"Current hp is: {currentHealth}");
        }

        public bool IsDead() { return health <= 0; }

        public abstract void Demand(SupplyCache currentCache);
        public abstract void SufferNight();
    }

    class Hunter : Consumers
    {
        public Hunter(string typeOfConsumer, int reqFood, int reqWood): base(typeOfConsumer,  reqFood, reqWood){}


        public override void Demand(SupplyCache currentCache) {
            bool success = currentCache.TryConsume(requiredRations, requiredFirewood);

            if (success)
            {
                Console.WriteLine($"{type} consumed {requiredRations} rations and {requiredFirewood} firewood. Survival secured.");
            }
            else
            {
                Console.WriteLine($"{type} finds the cache empty. You got this.");
            }
        }

        public override void SufferNight()
        {
            health -= 10;
            Console.WriteLine($"Hunter has lost his 10 health points. Remaining health: {health}");
        }
    }

    class Wounded : Consumers
    {
        public Wounded(string typeOfConsumer, int reqFood, int reqWood) : base(typeOfConsumer, reqFood, reqWood) { }


        public override void Demand(SupplyCache currentCache)
        {
            bool success = currentCache.TryConsume(requiredRations, requiredFirewood);

            if (success)
            {
                Console.WriteLine($"{type} consumed {requiredRations} rations and {requiredFirewood} firewood. Survival secured.");
            }
            else
            {
                Console.WriteLine($"{type} finds the cache empty. You are goona die bro.");
            }
        }
        public override void SufferNight()
        {
            health -= 20;
            Console.WriteLine($"Wounded has lost his 20 health points. Remaining health: {health}");
        }
    }
    class Child : Consumers
    {
        public Child(string typeOfConsumer, int reqFood, int reqWood) : base(typeOfConsumer, reqFood, reqWood) { }


        public override void Demand(SupplyCache currentCache)
        {
            bool success = currentCache.TryConsume(requiredRations, requiredFirewood);

            if (success)
            {
                Console.WriteLine($"{type} consumed {requiredRations} rations and {requiredFirewood} firewood. Survival secured.");
            }
            else
            {
                Console.WriteLine($"{type} finds the cache empty. I want my mom.");
            }
        }
        public override void SufferNight()
        {
            health -= 25;
            Console.WriteLine($"Child has lost his 25 health points. Remaining health: {health}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            SupplyCache mainVault = new SupplyCache(100, 100);

            Hunter loneHunter = new Hunter("The Hunter", 2, 0);
            Child sickChild = new Child("The Child", 1, 2);
            Wounded woundedHunter = new Wounded("The Wounded", 2, 3);

            int days = 1;

            while (true)
            {
                if (days == 5)
                {
                    Console.WriteLine("\nDay 5 dawns. You hear the sound of engines outside. Rescue has arrived. YOU WIN!");
                    break;
                }

                Console.WriteLine($"Day {days}, journey begins!");
                Thread.Sleep(5000);
                Console.WriteLine("Night time arrived! Time to make decisions. Select via number. \n 1- Hunter gets the resource. \n 2- Child gets the resource. \n 3- Wounded gets the resource.\nOne person at time can get resource.");

                string userSelection = Console.ReadLine();



                if (userSelection == "1")
                {
                    loneHunter.Demand(mainVault);
                    loneHunter.CheckHealth();
                    sickChild.SufferNight();
                    sickChild.CheckHealth();
                    woundedHunter.SufferNight();
                    woundedHunter.CheckHealth();
                    

                }
                else if (userSelection == "2")
                {
                    sickChild.Demand(mainVault);
                    sickChild.CheckHealth();
                    loneHunter.SufferNight();
                    loneHunter.CheckHealth();
                    woundedHunter.SufferNight();
                    woundedHunter.CheckHealth();
                }
                else if (userSelection == "3")
                {
                    woundedHunter.Demand(mainVault);
                    woundedHunter.CheckHealth();
                    loneHunter.SufferNight();
                    loneHunter.CheckHealth();
                    sickChild.SufferNight();
                    sickChild.CheckHealth();

                }



                if (loneHunter.IsDead() || sickChild.IsDead() || woundedHunter.IsDead())
                {
                    Console.WriteLine("\nA survivor has fallen. The psychological toll is too great. GAME OVER.");
                    break; 
                }


                





                mainVault.PrintStatus();
                days++;
            }


        }
    }
}
