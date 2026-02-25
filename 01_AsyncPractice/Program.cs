using System;
using System.Threading.Tasks; // We need this to use Tasks!

internal class Program
{
    // 1. The Main function is now 'async Task'. 
    // This allows the main program to handle "buzzers" (Tasks) without freezing.
    static async Task Main(string[] args)
    {
        Console.WriteLine("Your order is being cooked, please stay a while here, we will get your table ready!");
        Task<int> nuggetBuzzer = CookNuggetsAsync();
        await CleanTableAsync();
        Console.WriteLine("Enjoy your meal");
    }

    // 2. An async Task (The "Clean Table" buzzer: takes time, but returns no data)
    static async Task CleanTableAsync()
    {
        Console.WriteLine("   -> Employee: Scrubbing table...");

        // Task.Delay is how we simulate doing background work for 3 seconds.
        // It's exactly like waiting for a 3D model to load from a hard drive!
        await Task.Delay(3000);

        Console.WriteLine("   -> Employee: Table is clean!");
        // Notice there is no "return" here, because it's just a Task (like void).
    }

    // 3. An async Task<int> (The "Nuggets" buzzer: takes time, AND returns data)
    static async Task<int> CookNuggetsAsync()
    {
        Console.WriteLine("   -> Employee: Frying nuggets...");

        // Simulate cooking for 2 seconds
        await Task.Delay(2000);

        Console.WriteLine("   -> Employee: Nuggets are done!");

        // Because the label is Task<int>, we MUST hand back an integer at the end.
        return 5;
    }
}