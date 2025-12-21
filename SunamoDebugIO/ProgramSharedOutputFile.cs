namespace SunamoDebugIO;

public partial class ProgramShared
{
    public static string NotExistsFiles
    {
        set => WriteAllText(notExistsFile, value);
        //ThisApp.Success("Output was written to " + notExistsFile);
    }

    public static string Output
    {
        set => WriteAllText(outputFile, value);
        //ThisApp.Success("Output was written to " + outputFile);
    }

    public static List<StringBuilder> OutputStringBuilders
    {
        set
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in value)
            {
                stringBuilder.AppendLine(item.ToString());
                stringBuilder.AppendLine();
                stringBuilder.AppendLine();
            }

            WriteAllText(outputFile, stringBuilder.ToString());
        }
    }

    public static string OutputJson
    {
        set => WriteAllText(outputJsonFile, value);
        //ThisApp.Success("Output was written to " + outputJsonFile);
    }

    public static string OutputHtml
    {
        set => WriteAllText(outputJsonFile, value);
        //ThisApp.Success("Output was written to " + outputJsonFile);
    }

    public static List<string> OutputL
    {
        set => WriteAllLines(outputFile, value);
        //ThisApp.Success("Output was written to " + outputFile);
    }


    public static string Output2
    {
        set => WriteAllText(output2File, value);
        //ThisApp.Success("Output was written to " + output2File);
    }

    public static List<string> OutputL2
    {
        set => WriteAllLines(output2File, value);
        //ThisApp.Success("Output was written to " + output2File);
    }

    private static void WriteAllText(string output2File, string value)
    {
        if (output2File == null) throw new Exception("Firstly you have to call ProgramShared.CreatePathToFiles");

        File.WriteAllText(output2File, value);
    }

    private static void WriteAllLines(string output2File, List<string> value)
    {
        if (output2File == null) throw new Exception("Firstly you have to call ProgramShared.CreatePathToFiles");

        File.WriteAllLines(output2File, value);
    }


    public static async void Output2Open()
    {
        WarningIfIsNull();

        PH.Codium(output2File);
    }

    public static void OutputOpen()
    {
        WarningIfIsNull();

        PH.Codium(outputFile);
    }

    public static void OutputJsonOpen()
    {
        WarningIfIsNull();

        PH.Codium(outputJsonFile);
    }

    public static void OutputHtmlOpen()
    {
        WarningIfIsNull();

        PH.Codium(outputHtmlFile);
    }

    public static void InputOpen(bool waitForConfirmationOfDataEntered = true)
    {
        WarningIfIsNull();

        PH.Codium(inputFile);

        if (waitForConfirmationOfDataEntered)
        {
            Console.WriteLine("Input file was opened, press enter after fill it");
            Console.ReadLine();
        }

    }

    private static void WarningIfIsNull()
    {
        if (PH.Codium == null) throw new Exception("Please set up PH.Codium");
    }
}