namespace SunamoDebugIO;

public partial class ProgramShared
{
    public static string NotExistsFiles
    {
        set => WriteAllText(NotExistsFile, value);
    }

    public static string Output
    {
        set => WriteAllText(OutputFile, value);
    }

    public static List<StringBuilder> OutputStringBuilders
    {
        set
        {
            var stringBuilder = new StringBuilder();
            foreach (var item in value)
            {
                stringBuilder.AppendLine(item.ToString());
                stringBuilder.AppendLine();
                stringBuilder.AppendLine();
            }

            WriteAllText(OutputFile, stringBuilder.ToString());
        }
    }

    public static string OutputJson
    {
        set => WriteAllText(OutputJsonFile, value);
    }

    public static string OutputHtml
    {
        set => WriteAllText(OutputHtmlFile, value);
    }

    public static List<string> OutputL
    {
        set => WriteAllLines(OutputFile, value);
    }


    public static string Output2
    {
        set => WriteAllText(Output2File, value);
    }

    public static List<string> OutputL2
    {
        set => WriteAllLines(Output2File, value);
    }

    private static void WriteAllText(string filePath, string value)
    {
        if (filePath == null) throw new Exception("Firstly you have to call ProgramShared.CreatePathToFiles");

        File.WriteAllText(filePath, value);
    }

    private static void WriteAllLines(string filePath, List<string> value)
    {
        if (filePath == null) throw new Exception("Firstly you have to call ProgramShared.CreatePathToFiles");

        File.WriteAllLines(filePath, value);
    }


    public static async void Output2Open()
    {
        WarningIfIsNull();

        PH.Codium(Output2File);
    }

    public static void OutputOpen()
    {
        WarningIfIsNull();

        PH.Codium(OutputFile);
    }

    public static void OutputJsonOpen()
    {
        WarningIfIsNull();

        PH.Codium(OutputJsonFile);
    }

    public static void OutputHtmlOpen()
    {
        WarningIfIsNull();

        PH.Codium(OutputHtmlFile);
    }

    public static void InputOpen(bool isWaitForInput = true)
    {
        WarningIfIsNull();

        PH.Codium(InputFile);

        if (isWaitForInput)
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
