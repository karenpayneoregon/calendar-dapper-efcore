using static UtilityLibrary.SpectreConsoleHelpers;
namespace DapperFrontend1;

internal partial class Program
{
    static async Task Main(string[] args)
    {
        await Example1();
        Console.WriteLine();

        await Example2();
        Console.WriteLine();

        await Example3();
        Console.WriteLine();

        ExitPrompt();
    }
}