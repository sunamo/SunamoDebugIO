
namespace SunamoDebugIO;



public partial class ProgramShared
{
    #region Toto musím implementovat do každé třídy - protože jsou static, tím že je zdědím ničeho nedosáhnu. Tím pádem je ani dědit nemusím a musím je impl. jako předávající vlastnosti.
    static string plainTxt = @"E:\vs\Projects\sunamoWithoutLocalDep\sunamo\plain.txt";
    public static Type type = typeof(ProgramShared);
    public static string outputFile = null;
    public static string outputJsonFile = null;
    public static string output2File = null;
    public static string notExistsFile = null;
    public static string inputFile = null;
    public static string inputFileJson = null;
    public static string input2File = null;
    public static string input3File = null;
    public static string inputHtmlFile = null;
    #endregion

    /// <summary>
    /// 3) Initialize base properties of every app
    /// In console put into InitNotUt / Init (Initilize.cs file)
    /// 
    /// Into A1 put AppData.ci.GetFileString from SunamoThisApp
    /// </summary>
    /// <param name="getFile"></param>
    public static async Task CreatePathToFiles(Func<string, string, string> getFile)
    {
        outputFile = getFile(AppStringsFolders.Output, "output.txt");
        outputJsonFile = getFile(AppStringsFolders.Output, "output.json");
        output2File = getFile(AppStringsFolders.Output, "output2.txt");
        notExistsFile = getFile(AppStringsFolders.Output, "notExistsFile.txt");
        inputFile = getFile(AppStringsFolders.Input, "input.txt");
        inputFileJson = getFile(AppStringsFolders.Input, "input.json");
        input2File = getFile(AppStringsFolders.Input, "input2.txt");
        input3File = getFile(AppStringsFolders.Input, "input3.txt");
        inputHtmlFile = getFile(AppStringsFolders.Input, "inputHtml.txt");

        await CreateFileIfDoesntExists(outputFile);
        await CreateFileIfDoesntExists(outputJsonFile);
        await CreateFileIfDoesntExists(output2File);
        await CreateFileIfDoesntExists(notExistsFile);
        await CreateFileIfDoesntExists(inputFile);
        await CreateFileIfDoesntExists(input2File);
        await CreateFileIfDoesntExists(input3File);
        await CreateFileIfDoesntExists(inputHtmlFile);

    }

    static async Task CreateFileIfDoesntExists(String path)
    {
        await File.AppendAllTextAsync(path, string.Empty);

        //foreach (var item in path)
        //{
        //    await File.AppendAllTextAsync(item, string.Empty);
        //}
    }
}
