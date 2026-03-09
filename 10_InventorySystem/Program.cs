namespace _10_InventorySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = new List<string>();


            while (true) {

                Console.WriteLine("1. Add Item \n2. View Backpack \n3. Exit");

                string choice = Console.ReadLine() ?? "";

                if (choice == "1")
                {
                    Console.WriteLine("Please name the item: ");
                    string item = Console.ReadLine() ?? "";
                    inventory.Add(item);
                    Console.WriteLine("The item is succesfully added to inventory");
                }
                else if (choice == "2")
                {
                    foreach (string item in inventory)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (choice == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please choose 1, 2, or 3.");
                }

            }

            Console.WriteLine("Thanks for playing.");


        }
    }
}
