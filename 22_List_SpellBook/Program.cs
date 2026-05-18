namespace _22_List_SpellBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] spells = { "Fireball", "Ice Shard", "Thunder Strike", "Shadow Bolt", "Heal" };
            List<string> spellBook = new List<string>();
            int mana = 100;


            do
            {
                Console.WriteLine("Current Mana: {0} \nPlease enter a spell name to add to your spell book (or type 'exit' to finish):", mana);
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Here is your spellBook: ");
                    foreach (string spell in spellBook)
                    {
                        Console.WriteLine(spell);
                    }
                    break;
                }
                else if (spells.Contains(input, StringComparer.OrdinalIgnoreCase))
                {
                    if (spellBook.Contains(input, StringComparer.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("You already know this spell.");
                    }
                    else
                    {
                        spellBook.Add(input);
                        Console.WriteLine($"{input} has been added to your spell book.");
                        mana -= 20;
                        if(mana <= 0)
                        {
                            Console.WriteLine("You have run out of mana.");
                            Console.WriteLine("Here is your spellBook: ");
                            foreach (string spell in spellBook)
                            {
                                Console.WriteLine(spell);
                            }
                           
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid spell name. Please try again.");
                }
            } while (true);
        }
    }
}
