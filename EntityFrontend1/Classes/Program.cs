using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace EntityFrontend1;
internal partial class Program
{
    [ModuleInitializer]
    public static void Init()
    {
        Console.Title = "Code sample EF Core";
        WindowUtility.SetConsoleWindowPosition(WindowUtility.AnchorWindow.Center);
    }

}
