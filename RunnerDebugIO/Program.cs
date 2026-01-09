// variables names: ok
using SunamoDebugIO;
using SunamoPlatformUwpInterop.AppData;

namespace RunnerDebugIO;

internal class Program
{
    const string AppName = "RunnerDebugIO";

    static void Main()
    {
        MainAsync().GetAwaiter().GetResult();
    }

    static async Task MainAsync()
    {
        AppData.ci.CreateAppFoldersIfDontExists(new SunamoPlatformUwpInterop.Args.CreateAppFoldersIfDontExistsArgs { AppName = AppName });
        await ProgramShared.CreatePathToFiles(AppData.ci.GetFileString);

        ProgramShared.Output = "Ahoj";
        ProgramShared.Output2 = "R";
        ProgramShared.OutputL = ["L"];
        ProgramShared.OutputJson = "J";
        ProgramShared.OutputOpen();
        ProgramShared.Output2Open();
        ProgramShared.OutputJsonOpen();
    }
}
