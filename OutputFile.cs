public partial class ProgramShared
{
    public static string NotExistsFiles
    {
        set
        {
            TF.WriteAllText(notExistsFile, value);
            ThisApp.SetStatus(TypeOfMessage.Success, "Output was written to " + notExistsFile);
        }
    }

    public static string Output
    {
        set
        {
            TF.WriteAllText(outputFile, value);
            ThisApp.SetStatus(TypeOfMessage.Success, "Output was written to " + outputFile);
        }
    }

    public static string OutputJson
    {
        set
        {
            TF.WriteAllText(outputJsonFile, value);
            ThisApp.SetStatus(TypeOfMessage.Success, "Output was written to " + outputJsonFile);
        }
    }

    public static List<string> OutputL
    {
        set
        {
            TF.WriteAllLines(outputFile, value);
            ThisApp.SetStatus(TypeOfMessage.Success, "Output was written to " + outputFile);
        }
    }



    public static string Output2
    {
        set
        {
            TF.WriteAllText(output2File, value);
            ThisApp.SetStatus(TypeOfMessage.Success, "Output was written to " + output2File);
        }
    }

    public static List<string> OutputL2
    {
        set
        {
            TF.WriteAllLines(output2File, value);
            ThisApp.SetStatus(TypeOfMessage.Success, "Output was written to " + output2File);
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
