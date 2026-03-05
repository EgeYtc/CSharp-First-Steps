namespace _08_Methods
{
    internal class Program
    {
        static int TakeDamage(int currentHealth)
        {
            Console.WriteLine("Ouch! Took 10damage!");

            int updatedHealth = currentHealth - 10;

            return updatedHealth;   
           
        }
        static void Main(string[] args)
        {
            int playerHealth = 100; 

            playerHealth = TakeDamage(playerHealth);
            Console.WriteLine($"Health after attack 1: {playerHealth}");

            playerHealth = TakeDamage(playerHealth);
            Console.WriteLine($"Health after attack 1: {playerHealth}");


        }
    }
}
