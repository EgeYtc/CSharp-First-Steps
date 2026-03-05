namespace _09_Array_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> inventory = new List<string>();

            inventory.Add("Sword");
            inventory.Add("Silver Coin");
            inventory.Add("Mana Potion");

            Console.WriteLine($"Second item is: {inventory[1]}");


            foreach ( string item in inventory ) 
            {
                Console.WriteLine(item);    
            }
        }
    }
}
