using System;
using System.Collections.Generic; // Required for Queues!

namespace _04_EnemyWave
{
    // 1. THE BLUEPRINT
    // This defines what every enemy in our game needs to exist.
    public class Enemy
    {
        public string Type;
        public int Health;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. THE SPAWN QUEUE
            // We build the First-In, First-Out waiting line for Wave 1
            Queue<Enemy> waveOne = new Queue<Enemy>();

            // 3. BUILD THE MONSTERS
            // Using 'new' to manufacture physical enemies in memory
            Enemy grunt1 = new Enemy();
            grunt1.Type = "Basic Blob";
            grunt1.Health = 10;

            Enemy grunt2 = new Enemy();
            grunt2.Type = "Fast Blob";
            grunt2.Health = 5;

            Enemy boss = new Enemy();
            boss.Type = "Giant Tank Blob";
            boss.Health = 100;

            // 4. GET IN LINE
            // We add them to the queue in the exact order we want them to spawn
            waveOne.Enqueue(grunt1);
            waveOne.Enqueue(grunt2);
            waveOne.Enqueue(boss);

            Console.WriteLine("--- WAVE 1 INCOMING ---");

            // 5. THE GAME LOOP
            // This loop says: "As long as the number of enemies in line is greater than 0, keep running this code."
            while (waveOne.Count > 0)
            {
                // Pull the next enemy from the front of the line
                Enemy spawnedEnemy = waveOne.Dequeue();

                // Announce the spawn to the screen
                Console.WriteLine("Spawned: " + spawnedEnemy.Type + " (HP: " + spawnedEnemy.Health + ")");
            }

            Console.WriteLine("--- WAVE COMPLETE ---");
        }
    }
}