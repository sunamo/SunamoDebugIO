namespace SunamoDebugIO;

public partial class ProgramShared
{
    public static async Task<string> InputHtml()
    {
        return await FileAsync.ReadAllTextAsync(InputHtmlFile);
    }

    public static
        async Task<string>
        Input()
    {
        return
            await
                FileAsync.ReadAllTextAsync(InputFile);
    }

    public static
        async Task<List<string>>
        InputL()
    {
        return (await FileAsync.ReadAllLinesAsync(InputFile)).ToList();
    }

    public static
        async Task<string>
        InputJson()
    {
        return await FileAsync.ReadAllTextAsync(InputFileJson);
    }
}
