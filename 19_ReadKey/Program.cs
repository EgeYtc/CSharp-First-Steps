namespace _19_ReadKey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;
            Console.TreatControlCAsInput = true;


            do
            {
                keyInfo = Console.ReadKey();

                if ((keyInfo.Modifiers & ConsoleModifiers.Alt) != 0)
                    Console.Write("ALT+");

                if ((keyInfo.Modifiers & ConsoleModifiers.Shift) != 0)
                    Console.Write("SHIFT+");

                if (((keyInfo.Modifiers & ConsoleModifiers.Control) != 0))
                    Console.Write("CTRL+");


            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
