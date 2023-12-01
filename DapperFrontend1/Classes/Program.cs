using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace DapperFrontend1;
internal partial class Program
{
    [ModuleInitializer]
    public static void Init()
    {
        AnsiConsole.MarkupLine("");
        Console.Title = "Code sample Dapper";
        WindowUtility.SetConsoleWindowPosition(WindowUtility.AnchorWindow.Center);
    }
}
