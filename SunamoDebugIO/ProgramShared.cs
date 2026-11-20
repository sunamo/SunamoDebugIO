namespace SunamoDebugIO;

public partial class ProgramShared
{
    /// <summary>
    /// Create path to files.
    /// </summary>
    /// <param name="getFile">The get file.</param>
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

    private static async Task CreateFileIfDoesntExists(string path)
    {
        await FileAsync.AppendAllTextAsync(path, string.Empty);
    }

    #region Properties - I have to implement this in every class because they are static, inheriting them achieves nothing

    /// <summary>
    /// Gets or sets the type.
    /// </summary>
    public static Type Type { get; set; } = typeof(ProgramShared);

    /// <summary>
    /// Gets or sets the output file.
    /// </summary>
    public static string OutputFile { get; set; } = "";

    /// <summary>
    /// Gets or sets the output json file.
    /// </summary>
    public static string OutputJsonFile { get; set; } = "";

    /// <summary>
    /// Gets or sets the output html file.
    /// </summary>
    public static string OutputHtmlFile { get; set; } = "";

    /// <summary>
    /// Gets or sets the output 2 file.
    /// </summary>
    public static string Output2File { get; set; } = "";

    /// <summary>
    /// Gets or sets the not exists file.
    /// </summary>
    public static string NotExistsFile { get; set; } = "";

    /// <summary>
    /// Gets or sets the input file.
    /// </summary>
    public static string InputFile { get; set; } = "";

    /// <summary>
    /// Gets or sets the input file json.
    /// </summary>
    public static string InputFileJson { get; set; } = "";

    /// <summary>
    /// Gets or sets the input 2 file.
    /// </summary>
    public static string Input2File { get; set; } = "";

    /// <summary>
    /// Gets or sets the input 3 file.
    /// </summary>
    public static string Input3File { get; set; } = "";

    /// <summary>
    /// Gets or sets the input html file.
    /// </summary>
    public static string InputHtmlFile { get; set; } = "";

    #endregion
}
