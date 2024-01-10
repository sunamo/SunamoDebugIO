namespace SunamoDebugIO;


public partial class ProgramShared
{
    public static string NotExistsFiles
    {
        set
        {
            File.WriteAllText(notExistsFile, value);
            ThisApp.Success("Output was written to " + notExistsFile);
        }
    }

    public static string Output
    {
        set
        {
            File.WriteAllText(outputFile, value);
            ThisApp.Success("Output was written to " + outputFile);
        }
    }

    public static string OutputJson
    {
        set
        {
            File.WriteAllText(outputJsonFile, value);
            ThisApp.Success("Output was written to " + outputJsonFile);
        }
    }

    public static List<string> OutputL
    {
        set
        {
            File.WriteAllLines(outputFile, value);
            ThisApp.Success("Output was written to " + outputFile);
        }
    }



    public static string Output2
    {
        set
        {
            File.WriteAllText(output2File, value);
            ThisApp.Success("Output was written to " + output2File);
        }
    }

    public static List<string> OutputL2
    {
        set
        {
            File.WriteAllLines(output2File, value);
            ThisApp.Success("Output was written to " + output2File);
        }
    }

    public static void Output2Open()
    {
        PHWin.Codium(output2File);
    }

    public static void OutputOpen()
    {
        PHWin.Codium(outputFile);
    }

    public static void OutputJsonOpen()
    {
        PHWin.Codium(outputJsonFile);
    }

    public static void InputOpen()
    {
        PHWin.Codium(inputFile);
    }
}
