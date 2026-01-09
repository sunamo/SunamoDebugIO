// variables names: ok
namespace SunamoDebugIO;

/// <summary>
/// EN: Shared functionality for program debug I/O operations including file paths and initialization
/// CZ: Sdílená funkcionalita pro debug I/O operace programu včetně cest k souborům a inicializace
/// </summary>
public partial class ProgramShared
{
    /// <summary>
    /// EN: Initializes base properties of every app. In console put into InitNotUt / Init (Initialize.cs file). Into A1 put AppData.ci.GetFileString from SunamoThisApp.
    /// CZ: Inicializuje základní vlastnosti každé aplikace. V konzoli umístěte do InitNotUt / Init (soubor Initialize.cs). Do A1 umístěte AppData.ci.GetFileString z SunamoThisApp.
    /// </summary>
    /// <param name="getFile">Function to get file path from folder and filename</param>
    public static async Task CreatePathToFiles(Func<string, string, string> getFile)
    {
        OutputFile = getFile(AppStringsFolders.Output, "output.txt");
        OutputJsonFile = getFile(AppStringsFolders.Output, "output.json");
        OutputHtmlFile = getFile(AppStringsFolders.Output, "output.html");
        Output2File = getFile(AppStringsFolders.Output, "output2.txt");
        NotExistsFile = getFile(AppStringsFolders.Output, "notExistsFile.txt");
        InputFile = getFile(AppStringsFolders.Input, "input.txt");
        InputFileJson = getFile(AppStringsFolders.Input, "input.json");
        Input2File = getFile(AppStringsFolders.Input, "input2.txt");
        Input3File = getFile(AppStringsFolders.Input, "input3.txt");
        InputHtmlFile = getFile(AppStringsFolders.Input, "inputHtml.html");

        await CreateFileIfDoesntExists(OutputFile);
        await CreateFileIfDoesntExists(OutputJsonFile);
        await CreateFileIfDoesntExists(OutputHtmlFile);
        await CreateFileIfDoesntExists(Output2File);
        await CreateFileIfDoesntExists(NotExistsFile);
        await CreateFileIfDoesntExists(InputFile);
        await CreateFileIfDoesntExists(Input2File);
        await CreateFileIfDoesntExists(Input3File);
        await CreateFileIfDoesntExists(InputHtmlFile);
    }

    /// <summary>
    /// EN: Creates a file if it doesn't exist by appending empty text
    /// CZ: Vytvoří soubor pokud neexistuje přidáním prázdného textu
    /// </summary>
    /// <param name="path">Path to the file</param>
    private static async Task CreateFileIfDoesntExists(string path)
    {
        await File.AppendAllTextAsync(path, string.Empty);
    }

    #region Properties - I have to implement this in every class because they are static, inheriting them achieves nothing

    /// <summary>
    /// EN: Type of the ProgramShared class
    /// CZ: Typ třídy ProgramShared
    /// </summary>
    public static Type Type { get; set; } = typeof(ProgramShared);

    /// <summary>
    /// EN: Path to the main output file
    /// CZ: Cesta k hlavnímu výstupnímu souboru
    /// </summary>
    public static string OutputFile { get; set; } = "";

    /// <summary>
    /// EN: Path to the JSON output file
    /// CZ: Cesta k JSON výstupnímu souboru
    /// </summary>
    public static string OutputJsonFile { get; set; } = "";

    /// <summary>
    /// EN: Path to the HTML output file
    /// CZ: Cesta k HTML výstupnímu souboru
    /// </summary>
    public static string OutputHtmlFile { get; set; } = "";

    /// <summary>
    /// EN: Path to the secondary output file
    /// CZ: Cesta k druhému výstupnímu souboru
    /// </summary>
    public static string Output2File { get; set; } = "";

    /// <summary>
    /// EN: Path to the file for non-existent entries
    /// CZ: Cesta k souboru pro neexistující záznamy
    /// </summary>
    public static string NotExistsFile { get; set; } = "";

    /// <summary>
    /// EN: Path to the main input file
    /// CZ: Cesta k hlavnímu vstupnímu souboru
    /// </summary>
    public static string InputFile { get; set; } = "";

    /// <summary>
    /// EN: Path to the JSON input file
    /// CZ: Cesta k JSON vstupnímu souboru
    /// </summary>
    public static string InputFileJson { get; set; } = "";

    /// <summary>
    /// EN: Path to the secondary input file
    /// CZ: Cesta k druhému vstupnímu souboru
    /// </summary>
    public static string Input2File { get; set; } = "";

    /// <summary>
    /// EN: Path to the tertiary input file
    /// CZ: Cesta k třetímu vstupnímu souboru
    /// </summary>
    public static string Input3File { get; set; } = "";

    /// <summary>
    /// EN: Path to the HTML input file
    /// CZ: Cesta k HTML vstupnímu souboru
    /// </summary>
    public static string InputHtmlFile { get; set; } = "";

    #endregion
}
