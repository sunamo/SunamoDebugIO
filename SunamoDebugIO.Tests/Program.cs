// variables names: ok
namespace SunamoDebugIO.Tests;

internal class Program : ProgramShared
{
    static void Main()
    {
        MainAsync().GetAwaiter().GetResult();
    }

    static async Task MainAsync()
    {
    }
}
