// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoDebugIO;

public partial class ProgramShared
{
    public static async Task<string> InputHtml()
    {
        return await File.ReadAllTextAsync(inputHtmlFile);
    }

    public static
#if ASYNC
        async Task<string>
#else
    string
#endif
        Input()
    {
        return
#if ASYNC
            await
#endif
                File.ReadAllTextAsync(inputFile);
    }

    public static
#if ASYNC
        async Task<List<string>>
#else
    List<string>
#endif
        InputL()
    {
        return (await File.ReadAllLinesAsync(inputFile)).ToList();
    }

    public static
#if ASYNC
        async Task<string>
#else
    string
#endif
        InputJson()
    {
        return await File.ReadAllTextAsync(inputFileJson);
    }
}