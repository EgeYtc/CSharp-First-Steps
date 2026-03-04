namespace _05_EnemyWave_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentWave = 3;
            int enemiesToSpawn = currentWave * 5;

            for (int i = 0; i < enemiesToSpawn; i++)
            {
                int enemyNumber = i + 1;
                Console.WriteLine("Spawning Enemy #" + enemyNumber);

            }


            Console.WriteLine("All enemies spawned. Good luck!");


        }


    }
}
