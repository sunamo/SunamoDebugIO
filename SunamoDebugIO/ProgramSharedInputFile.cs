namespace SunamoDebugIO;

/// <summary>
/// EN: Input file-related functionality for ProgramShared
/// CZ: Funkcionalita související se vstupními soubory pro ProgramShared
/// </summary>
public partial class ProgramShared
{
    /// <summary>
    /// EN: Reads the content of HTML input file
    /// CZ: Přečte obsah HTML vstupního souboru
    /// </summary>
    /// <returns>HTML file content as string</returns>
    public static async Task<string> InputHtml()
    {
        return await FileAsync.ReadAllTextAsync(InputHtmlFile);
    }

    /// <summary>
    /// EN: Reads the content of main input file
    /// CZ: Přečte obsah hlavního vstupního souboru
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
    /// EN: Reads the content of main input file as a list of lines
    /// CZ: Přečte obsah hlavního vstupního souboru jako seznam řádků
    /// </summary>
    /// <returns>Input file content as list of strings</returns>
    public static
        async Task<List<string>>
        InputL()
    {
        return (await FileAsync.ReadAllLinesAsync(InputFile)).ToList();
    }

    /// <summary>
    /// EN: Reads the content of JSON input file
    /// CZ: Přečte obsah JSON vstupního souboru
    /// </summary>
    /// <returns>JSON file content as string</returns>
    public static
        async Task<string>
        InputJson()
    {
        return await FileAsync.ReadAllTextAsync(InputFileJson);
    }
}