namespace SunamoDebugIO;

public partial class ProgramShared
{
    public static async Task<string> InputHtml()
    {
        return await File.ReadAllTextAsync(InputHtmlFile);
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
                File.ReadAllTextAsync(InputFile);
    }

    public static
#if ASYNC
        async Task<List<string>>
#else
    List<string>
#endif
        InputL()
    {
        return (await File.ReadAllLinesAsync(InputFile)).ToList();
    }

    public static
#if ASYNC
        async Task<string>
#else
    string
#endif
        InputJson()
    {
        return await File.ReadAllTextAsync(InputFileJson);
    }
}