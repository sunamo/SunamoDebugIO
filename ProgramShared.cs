using SunamoValues;

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
    /// </summary>
    /// <param name="getFile"></param>
    public static async Task CreatePathToFiles(Func<string, string, string> getFile)
    {
        outputFile = getFile(AppFoldersStrings.Output, "output.txt");
        outputJsonFile = getFile(AppFoldersStrings.Output, "output.json");
        output2File = getFile(AppFoldersStrings.Output, "output2.txt");
        notExistsFile = getFile(AppFoldersStrings.Output, "notExistsFile.txt");
        inputFile = getFile(AppFoldersStrings.Input, "input.txt");
        inputFileJson = getFile(AppFoldersStrings.Input, "input.json");
        input2File = getFile(AppFoldersStrings.Input, "input2.txt");
        input3File = getFile(AppFoldersStrings.Input, "input3.txt");
        inputHtmlFile = getFile(AppFoldersStrings.Input, "inputHtml.txt");

        await FS.CreateFileIfDoesntExists(outputFile);
        await FS.CreateFileIfDoesntExists(outputJsonFile);
        await FS.CreateFileIfDoesntExists(output2File);
        await FS.CreateFileIfDoesntExists(notExistsFile);
        await FS.CreateFileIfDoesntExists(inputFile);
        await FS.CreateFileIfDoesntExists(input2File);
        await FS.CreateFileIfDoesntExists(input3File);
        await FS.CreateFileIfDoesntExists(inputHtmlFile);

    }
}
