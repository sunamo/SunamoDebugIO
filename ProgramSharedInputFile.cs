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
        return SHGetLines.GetLines(
#if ASYNC
            await
#endif
                File.ReadAllTextAsync(inputFile)).ToList();
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