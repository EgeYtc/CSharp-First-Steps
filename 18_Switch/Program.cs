namespace _18_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string enemyState = "Attack";
            


            switch (enemyState)
            {
                case "Patrol":
                    Console.WriteLine("The guard is pacing back and forth.");
                    break;
                case "Chase":
                    Console.WriteLine("The guard spots you and runs toward you!");
                    break;
                case "Attack":
                    Console.WriteLine("The guard swings his broadsword!");
                    break;
                default:
                    Console.WriteLine("The guard is standing still, confused.");
                    break;
            }
            }
    }
}
