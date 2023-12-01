using System.Diagnostics;

namespace EntityFrontend1.Classes;

public static class Extensions
{
    [DebuggerStepThrough]
    public static string ToYesNo(this bool value) => value ? "Yes" : "No";
}