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
        //SunamoXlf.TranslateDictionary.returnXlfKey = true;
        //ThisApp.Name = "ToNugets";
        //AppData.ci.CreateAppFoldersIfDontExists(new SunamoPlatformUwpInterop.Args.CreateAppFoldersIfDontExistsArgs { });
        //await CreatePathToFiles(AppData.ci.GetFileString);
        //Output = "ab";
    }
}
