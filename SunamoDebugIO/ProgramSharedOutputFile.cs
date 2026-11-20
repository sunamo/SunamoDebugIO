namespace SunamoDebugIO;

public partial class ProgramShared
{
    /// <summary>
    /// The not exists files.
    /// </summary>
    public static string NotExistsFiles
    {
        set => WriteAllText(NotExistsFile, value);
    }

    /// <summary>
    /// The output.
    /// </summary>
    public static string Output
    {
        set => WriteAllText(OutputFile, value);
    }

    /// <summary>
    /// The output string builders.
    /// </summary>
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

    /// <summary>
    /// The output json.
    /// </summary>
    public static string OutputJson
    {
        set => WriteAllText(OutputJsonFile, value);
    }

    /// <summary>
    /// The output html.
    /// </summary>
    public static string OutputHtml
    {
        set => WriteAllText(OutputHtmlFile, value);
    }

    /// <summary>
    /// The output l.
    /// </summary>
    public static List<string> OutputL
    {
        set => WriteAllLines(OutputFile, value);
    }


    /// <summary>
    /// The output 2.
    /// </summary>
    public static string Output2
    {
        set => WriteAllText(Output2File, value);
    }

    /// <summary>
    /// The output l 2.
    /// </summary>
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


    /// <summary>
    /// Output 2 open.
    /// </summary>
    /// <param name="Output2File">The output 2 file.</param>
    /// <param name="value">The value.</param>
    /// <returns>The output 2 open result.</returns>
    public static async void Output2Open()
    {
        WarningIfIsNull();

        PH.Codium(Output2File);
    }

    /// <summary>
    /// Output open.
    /// </summary>
    /// <param name="filePath">The file path.</param>
    /// <param name="value">The value.</param>
    /// <returns>The output open result.</returns>
    public static void OutputOpen()
    {
        WarningIfIsNull();

        PH.Codium(OutputFile);
    }

    /// <summary>
    /// Output json open.
    /// </summary>
    /// <param name="filePath">The file path.</param>
    /// <param name="value">The value.</param>
    /// <returns>The output json open result.</returns>
    public static void OutputJsonOpen()
    {
        WarningIfIsNull();

        PH.Codium(OutputJsonFile);
    }

    /// <summary>
    /// Output html open.
    /// </summary>
    /// <returns>The output html open result.</returns>
    public static void OutputHtmlOpen()
    {
        WarningIfIsNull();

        PH.Codium(OutputHtmlFile);
    }

    /// <summary>
    /// Initializes a new instance of the input open class.
    /// </summary>
    /// <param name="Output2File">The output 2 file.</param>
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
