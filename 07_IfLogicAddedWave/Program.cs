namespace _07_IfLogicAddedWave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseHeatlh = 10;
            int waveNumber = 1;

            while (baseHeatlh > 0)
            {
                Console.WriteLine($"Current Wave: {waveNumber}");

                for (int i = 0; i < 3; i++)
                {
                    if (baseHeatlh <= 0)
                    {
                        // 2. The Emergency Eject!
                        break;
                    }

                    Console.WriteLine("Enemy Spawned!");
                    baseHeatlh--;
                }

                waveNumber++;

                if (baseHeatlh <= 0)
                {
                    Console.WriteLine("CRITICAL FAILURE: Base Destroyed!");
                }
                else if (baseHeatlh <= 3)
                {
                    // It only checks this if baseHealth is greater than 0
                    Console.WriteLine("WARNING: Base hull integrity is critically low!");
                }
                else if (baseHeatlh == 10)
                {
                    // Notice the double equals == for checking if two things are exactly the same!
                    Console.WriteLine("FLAWLESS DEFENSE: Base took no damage this wave.");
                }
                else
                {
                    // If it's not dead, not low, and not flawless, it must be somewhere in the middle (4 to 9).
                    Console.WriteLine("Status Normal: Base is holding strong.");
                }

            }

            Console.WriteLine("Base Destroyed! Game Over");
        }
    }
}
