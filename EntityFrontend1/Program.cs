using static UtilityLibrary.SpectreConsoleHelpers;

namespace EntityFrontend1;
internal partial class Program
{
    static async Task Main(string[] args)
    {
        await Task.Delay(0);

        await Example1();
        Console.WriteLine();

        await Example2();
        Console.WriteLine();

        await Example3();

        ExitPrompt();
    }
}