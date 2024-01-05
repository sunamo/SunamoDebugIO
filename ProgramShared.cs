using SunamoDebugIO._sunamo;

namespace SunamoDebugIO;

public partial class ProgramShared
{
    #region Toto musím implementovat do každé třídy - protože jsou static, tím že je zdědím ničeho nedosáhnu. Tím pádem je ani dědit nemusím a musím je impl. jako předávající vlastnosti.
    static string plainTxt = @"E:\vs\Projects\sunamo\sunamo\plain.txt";
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
    public static void CreatePathToFiles(Func<string, string, string> getFile)
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

        FS.CreateFileIfDoesntExists(outputFile);
        FS.CreateFileIfDoesntExists(outputJsonFile);
        FS.CreateFileIfDoesntExists(output2File);
        FS.CreateFileIfDoesntExists(notExistsFile);
        FS.CreateFileIfDoesntExists(inputFile);
        FS.CreateFileIfDoesntExists(input2File);
        FS.CreateFileIfDoesntExists(input3File);
        FS.CreateFileIfDoesntExists(inputHtmlFile);

    }
}
