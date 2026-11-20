namespace SunamoDebugIO;

/// <summary>
/// Input file-related functionality for ProgramShared
/// </summary>
public partial class ProgramShared
{
    /// <summary>
    /// Reads the content of HTML input file
    /// </summary>
    /// <returns>HTML file content as string</returns>
    public static async Task<string> InputHtml()
    {
        return await FileAsync.ReadAllTextAsync(InputHtmlFile);
    }

    /// <summary>
    /// Reads the content of main input file
    /// </summary>
    /// <returns>Input file content as string</returns>
    public static
        async Task<string>
        Input()
    {
        return
            await
                FileAsync.ReadAllTextAsync(InputFile);
    }

    /// <summary>
    /// Reads the content of main input file as a list of lines
    /// </summary>
    /// <returns>Input file content as list of strings</returns>
    public static
        async Task<List<string>>
        InputL()
    {
        return (await FileAsync.ReadAllLinesAsync(InputFile)).ToList();
    }

    /// <summary>
    /// Reads the content of JSON input file
    /// </summary>
    /// <returns>JSON file content as string</returns>
    public static
        async Task<string>
        InputJson()
    {
        return await FileAsync.ReadAllTextAsync(InputFileJson);
    }
}