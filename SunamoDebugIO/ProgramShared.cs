namespace SunamoDebugIO;

public partial class ProgramShared
{
    /// <summary>
    ///     3) Initialize base properties of every app
    ///     In console put into InitNotUt / Init (Initilize.cs file)
    ///     Into A1 put AppData.ci.GetFileString from SunamoThisApp
    /// </summary>
    /// <param name="getFile"></param>
    public static async Task CreatePathToFiles(Func<string, string, string> getFile)
    {
        outputFile = getFile(AppStringsFolders.Output, "output.txt");
        outputJsonFile = getFile(AppStringsFolders.Output, "output.json");
        outputHtmlFile = getFile(AppStringsFolders.Output, "output.html");
        output2File = getFile(AppStringsFolders.Output, "output2.txt");
        notExistsFile = getFile(AppStringsFolders.Output, "notExistsFile.txt");
        inputFile = getFile(AppStringsFolders.Input, "input.txt");
        inputFileJson = getFile(AppStringsFolders.Input, "input.json");
        input2File = getFile(AppStringsFolders.Input, "input2.txt");
        input3File = getFile(AppStringsFolders.Input, "input3.txt");
        inputHtmlFile = getFile(AppStringsFolders.Input, "inputHtml.html");

        await CreateFileIfDoesntExists(outputFile);
        await CreateFileIfDoesntExists(outputJsonFile);
        await CreateFileIfDoesntExists(outputHtmlFile);
        await CreateFileIfDoesntExists(output2File);
        await CreateFileIfDoesntExists(notExistsFile);
        await CreateFileIfDoesntExists(inputFile);
        await CreateFileIfDoesntExists(input2File);
        await CreateFileIfDoesntExists(input3File);
        await CreateFileIfDoesntExists(inputHtmlFile);
    }

    private static async Task CreateFileIfDoesntExists(string path)
    {
        await File.AppendAllTextAsync(path, string.Empty);

        //foreach (var item in path)
        //{
        //    await File.AppendAllTextAsync(item, string.Empty);
        //}
    }

    #region Toto musím implementovat do každé třídy - protože jsou static, tím že je zdědím ničeho nedosáhnu. Tím pádem je ani dědit nemusím a musím je impl. jako předávající vlastnosti.


    public static Type type = typeof(ProgramShared);
    public static string outputFile = "";
    public static string outputJsonFile = "";
    public static string outputHtmlFile = "";
    public static string output2File = "";
    public static string notExistsFile = "";
    public static string inputFile = "";
    public static string inputFileJson = "";
    public static string input2File = "";
    public static string input3File = "";
    public static string inputHtmlFile = "";

    #endregion
}