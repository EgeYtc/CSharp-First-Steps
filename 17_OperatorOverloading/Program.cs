namespace _17_OperatorOverloading
{
    internal class Program
    {

        class StatBlock
        {
            public int Strength;
            public int Agility;
            public int Intelligence;
            public int allStats;


            public StatBlock(int STR, int AGI, int INT)
            {
                Strength = STR;
                Agility = AGI;
                Intelligence = INT;
                allStats = STR + AGI + INT;
            }


            public static StatBlock operator +(StatBlock p1, StatBlock p2)
            {
                return new StatBlock(p1.Strength + p2.Strength, p1.Agility + p2.Agility, p1.Intelligence + p2.Intelligence);
            }


            public override string ToString()
            {
                return $"Total Stats: {allStats} (STR: {Strength}, AGI: {Agility}, INT: {Intelligence})";
            }



        }

        static void Main(string[] args)
        {
            StatBlock player1 = new StatBlock(3, 4, 5);
            StatBlock player2 = new StatBlock(4, 4, 4);
            StatBlock result = player1 + player2;
            Console.WriteLine($"Result of player1 + player2 = {result}");

        }
    }
}
