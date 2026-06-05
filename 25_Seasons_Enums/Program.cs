namespace _25_Seasons_Enums
{
    internal class Program
    {
        enum WeaponType { Sword, Bow, Staff, Dagger };

        class Player
        {
            public string name;
            public WeaponType type;
        }
        static void PrintWeapon(Player player)
        {
            switch (player.type)
            {
                case WeaponType.Sword:
                    Console.WriteLine($"{player.name} equipped a Sword — close range fighter!");
                    break;
                case WeaponType.Bow:
                    Console.WriteLine($"{player.name} equipped a Bow — ranged attacker!");
                    break;
                case WeaponType.Staff:
                    Console.WriteLine($"{player.name} equipped a Staff — magic user!");
                    break;
                case WeaponType.Dagger:
                    Console.WriteLine($"{player.name} equipped a Dagger — stealth assassin!");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();
            player.name = "Archer";

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Current weapon: {player.type}");
                Console.WriteLine("\nChoose your weapon:");
                Console.WriteLine("1 - Sword");
                Console.WriteLine("2 - Bow");
                Console.WriteLine("3 - Staff");
                Console.WriteLine("4 - Dagger");
                Console.WriteLine("Q - Quit");

                ConsoleKey key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.D1:
                        player.type = WeaponType.Sword;
                        break;
                    case ConsoleKey.D2:
                        player.type = WeaponType.Bow;
                        break;
                    case ConsoleKey.D3:
                        player.type = WeaponType.Staff;
                        break;
                    case ConsoleKey.D4:
                        player.type = WeaponType.Dagger;
                        break;
                    case ConsoleKey.Q:
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid key!");
                        break;
                }

                PrintWeapon(player);
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey(true);
            }

        }
    }
}
