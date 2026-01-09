// variables names: ok
namespace SunamoDebugIO;

/// <summary>
/// EN: Output file-related functionality for ProgramShared
/// CZ: Funkcionalita související s výstupními soubory pro ProgramShared
/// </summary>
public partial class ProgramShared
{
    /// <summary>
    /// EN: Sets the content of NotExistsFile
    /// CZ: Nastaví obsah NotExistsFile
    /// </summary>
    public static string NotExistsFiles
    {
        set => WriteAllText(NotExistsFile, value);
    }

    /// <summary>
    /// EN: Sets the content of main output file
    /// CZ: Nastaví obsah hlavního výstupního souboru
    /// </summary>
    public static string Output
    {
        set => WriteAllText(OutputFile, value);
    }

    /// <summary>
    /// EN: Sets the content of output file from a list of StringBuilders, separating each with blank lines
    /// CZ: Nastaví obsah výstupního souboru ze seznamu StringBuilderů, každý oddělí prázdnými řádky
    /// </summary>
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

            WriteAllText(OutputFile, stringBuilder.ToString());
        }
    }

    /// <summary>
    /// EN: Sets the content of JSON output file
    /// CZ: Nastaví obsah JSON výstupního souboru
    /// </summary>
    public static string OutputJson
    {
        set => WriteAllText(OutputJsonFile, value);
    }

    /// <summary>
    /// EN: Sets the content of HTML output file
    /// CZ: Nastaví obsah HTML výstupního souboru
    /// </summary>
    public static string OutputHtml
    {
        set => WriteAllText(OutputHtmlFile, value);
    }

    /// <summary>
    /// EN: Sets the content of output file from a list of strings (writes all lines)
    /// CZ: Nastaví obsah výstupního souboru ze seznamu stringů (zapíše všechny řádky)
    /// </summary>
    public static List<string> OutputL
    {
        set => WriteAllLines(OutputFile, value);
    }


    /// <summary>
    /// EN: Sets the content of secondary output file
    /// CZ: Nastaví obsah druhého výstupního souboru
    /// </summary>
    public static string Output2
    {
        set => WriteAllText(Output2File, value);
    }

    /// <summary>
    /// EN: Sets the content of secondary output file from a list of strings (writes all lines)
    /// CZ: Nastaví obsah druhého výstupního souboru ze seznamu stringů (zapíše všechny řádky)
    /// </summary>
    public static List<string> OutputL2
    {
        set => WriteAllLines(Output2File, value);
    }

    /// <summary>
    /// EN: Writes all text to a file, throws exception if path is null
    /// CZ: Zapíše všechen text do souboru, vyhodí výjimku pokud je cesta null
    /// </summary>
    /// <param name="filePath">Path to the file</param>
    /// <param name="value">Text content to write</param>
    private static void WriteAllText(string filePath, string value)
    {
        if (filePath == null) throw new Exception("Firstly you have to call ProgramShared.CreatePathToFiles");

        File.WriteAllText(filePath, value);
    }

    /// <summary>
    /// EN: Writes all lines to a file, throws exception if path is null
    /// CZ: Zapíše všechny řádky do souboru, vyhodí výjimku pokud je cesta null
    /// </summary>
    /// <param name="filePath">Path to the file</param>
    /// <param name="value">List of lines to write</param>
    private static void WriteAllLines(string filePath, List<string> value)
    {
        if (filePath == null) throw new Exception("Firstly you have to call ProgramShared.CreatePathToFiles");

        File.WriteAllLines(filePath, value);
    }


    /// <summary>
    /// EN: Opens the secondary output file in VSCodium editor
    /// CZ: Otevře druhý výstupní soubor v editoru VSCodium
    /// </summary>
    public static async void Output2Open()
    {
        WarningIfIsNull();

        PH.Codium(Output2File);
    }

    /// <summary>
    /// EN: Opens the main output file in VSCodium editor
    /// CZ: Otevře hlavní výstupní soubor v editoru VSCodium
    /// </summary>
    public static void OutputOpen()
    {
        WarningIfIsNull();

        PH.Codium(OutputFile);
    }

    /// <summary>
    /// EN: Opens the JSON output file in VSCodium editor
    /// CZ: Otevře JSON výstupní soubor v editoru VSCodium
    /// </summary>
    public static void OutputJsonOpen()
    {
        WarningIfIsNull();

        PH.Codium(OutputJsonFile);
    }

    /// <summary>
    /// EN: Opens the HTML output file in VSCodium editor
    /// CZ: Otevře HTML výstupní soubor v editoru VSCodium
    /// </summary>
    public static void OutputHtmlOpen()
    {
        WarningIfIsNull();

        PH.Codium(OutputHtmlFile);
    }

    /// <summary>
    /// EN: Opens the input file in VSCodium editor, optionally waits for user confirmation after filling
    /// CZ: Otevře vstupní soubor v editoru VSCodium, volitelně čeká na potvrzení uživatele po vyplnění
    /// </summary>
    /// <param name="isWaitForInput">Whether to wait for user to press enter after filling the file</param>
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

    /// <summary>
    /// EN: Checks if PH.Codium is set up, throws exception if not
    /// CZ: Zkontroluje zda je PH.Codium nastaven, vyhodí výjimku pokud ne
    /// </summary>
    private static void WarningIfIsNull()
    {
        if (PH.Codium == null) throw new Exception("Please set up PH.Codium");
    }
}
