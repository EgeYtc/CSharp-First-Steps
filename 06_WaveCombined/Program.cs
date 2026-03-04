namespace _06_WaveCombined
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

            }

            Console.WriteLine("Base Destroyed! Game Over");
        }
    }
}
