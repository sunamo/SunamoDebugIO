namespace SunamoDebugIO;

public partial class ProgramShared
{
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

    public static Type Type { get; set; } = typeof(ProgramShared);

    public static string OutputFile { get; set; } = "";

    public static string OutputJsonFile { get; set; } = "";

    public static string OutputHtmlFile { get; set; } = "";

    public static string Output2File { get; set; } = "";

    public static string NotExistsFile { get; set; } = "";

    public static string InputFile { get; set; } = "";

    public static string InputFileJson { get; set; } = "";

    public static string Input2File { get; set; } = "";

    public static string Input3File { get; set; } = "";

    public static string InputHtmlFile { get; set; } = "";

    #endregion
}
