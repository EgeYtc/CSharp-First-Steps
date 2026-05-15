using static System.Net.WebRequestMethods;

namespace _21_DataStructures_Dungeon
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string[] rooms = { "Throne Room", "Armory", "Dungeon", "Library", "Barracks" };
            List<string> visitedRooms = new List<string>();
            int fails = 0;
            do
            {
                Console.Write("Enter a room name: ");
                string? choice = Console.ReadLine();
                
              
                    if (choice == "exit")
                {
                    for (int i = 0; i < visitedRooms.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {visitedRooms[i]}");
                    }
                    Console.WriteLine($"Number of failed attempts: {fails}");
                    break;
                }
                        

                    if (Array.Exists(rooms, r => r == choice))
                    {
                        if (visitedRooms.Contains(choice))
                        {
                            Console.WriteLine("You have already visited this room.");
                            
                    }
                        else
                        {
                            visitedRooms.Add(choice);
                            Console.WriteLine("You entered: " + choice);
                        }
                    }
                    else
                    {
                        Console.WriteLine("This room does not exist.");
                        fails++;



                }

                



            } while (true);

            
        }
    }
}
