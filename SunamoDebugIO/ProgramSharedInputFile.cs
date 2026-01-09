// variables names: ok
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
        return await File.ReadAllTextAsync(InputHtmlFile);
    }

    /// <summary>
    /// EN: Reads the content of main input file
    /// CZ: Přečte obsah hlavního vstupního souboru
    /// </summary>
    /// <returns>Input file content as string</returns>
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

    /// <summary>
    /// EN: Reads the content of main input file as a list of lines
    /// CZ: Přečte obsah hlavního vstupního souboru jako seznam řádků
    /// </summary>
    /// <returns>Input file content as list of strings</returns>
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

    /// <summary>
    /// EN: Reads the content of JSON input file
    /// CZ: Přečte obsah JSON vstupního souboru
    /// </summary>
    /// <returns>JSON file content as string</returns>
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
