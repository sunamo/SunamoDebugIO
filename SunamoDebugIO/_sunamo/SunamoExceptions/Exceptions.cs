// variables names: ok
namespace SunamoDebugIO._sunamo.SunamoExceptions;

// © www.sunamo.cz. All Rights Reserved.
/// <summary>
/// EN: Helper class for exception handling and formatting
/// CZ: Pomocná třída pro zpracování a formátování výjimek
/// </summary>
internal sealed partial class Exceptions
{
    #region Other
    /// <summary>
    /// EN: Adds colon and space to prefix text if it's not empty, otherwise returns empty string
    /// CZ: Přidá dvojtečku a mezeru k prefixovému textu pokud není prázdný, jinak vrátí prázdný řetězec
    /// </summary>
    /// <param name="before">Prefix text to check</param>
    /// <returns>Formatted prefix with colon and space, or empty string</returns>
    internal static string CheckBefore(string before)
    {
        return string.IsNullOrWhiteSpace(before) ? string.Empty : before + ": ";
    }

    /// <summary>
    /// EN: Gets the place where exception occurred by analyzing stack trace
    /// CZ: Získá místo kde došlo k výjimce analýzou zásobníku volání
    /// </summary>
    /// <param name="isFillAlsoFirstTwo">Whether to fill also first two elements (type and method name)</param>
    /// <returns>Tuple containing type name, method name, and formatted stack trace</returns>
    internal static Tuple<string, string, string> PlaceOfException(bool isFillAlsoFirstTwo = true)
    {
        StackTrace stackTrace = new();
        var value = stackTrace.ToString();
        var lines = value.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
        lines.RemoveAt(0);
        var currentIndex = 0;
        string type = string.Empty;
        string methodName = string.Empty;
        for (; currentIndex < lines.Count; currentIndex++)
        {
            var item = lines[currentIndex];
            if (isFillAlsoFirstTwo)
                if (!item.StartsWith("   at ThrowEx"))
                {
                    TypeAndMethodName(item, out type, out methodName);
                    isFillAlsoFirstTwo = false;
                }
            if (item.StartsWith("at System."))
            {
                lines.Add(string.Empty);
                lines.Add(string.Empty);
                break;
            }
        }
        return new Tuple<string, string, string>(type, methodName, string.Join(Environment.NewLine, lines));
    }

    /// <summary>
    /// EN: Parses type name and method name from a stack trace line
    /// CZ: Parsuje název typu a název metody z řádku zásobníku volání
    /// </summary>
    /// <param name="line">Stack trace line to parse</param>
    /// <param name="type">Output parameter for type name</param>
    /// <param name="methodName">Output parameter for method name</param>
    internal static void TypeAndMethodName(string line, out string type, out string methodName)
    {
        var trimmedText = line.Split("at ")[1].Trim();
        var text = trimmedText.Split("(")[0];
        var nameParts = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        methodName = nameParts[^1];
        nameParts.RemoveAt(nameParts.Count - 1);
        type = string.Join(".", nameParts);
    }

    /// <summary>
    /// EN: Gets the name of the calling method by analyzing stack trace
    /// CZ: Získá název volající metody analýzou zásobníku volání
    /// </summary>
    /// <param name="frameIndex">Stack frame index to retrieve (default is 1)</param>
    /// <returns>Method name or error message if method cannot be retrieved</returns>
    internal static string CallingMethod(int frameIndex = 1)
    {
        StackTrace stackTrace = new();
        var methodBase = stackTrace.GetFrame(frameIndex)?.GetMethod();
        if (methodBase == null)
        {
            return "Method name cannot be get";
        }
        var methodName = methodBase.Name;
        return methodName;
    }
    #endregion

    #region IsNullOrWhitespace
    /// <summary>
    /// EN: StringBuilder for additional inner information in exceptions
    /// CZ: StringBuilder pro dodatečné vnitřní informace ve výjimkách
    /// </summary>
    internal readonly static StringBuilder AdditionalInfoInnerStringBuilder = new();

    /// <summary>
    /// EN: StringBuilder for additional information in exceptions
    /// CZ: StringBuilder pro dodatečné informace ve výjimkách
    /// </summary>
    internal readonly static StringBuilder AdditionalInfoStringBuilder = new();
    #endregion

    /// <summary>
    /// EN: Checks if a parameter value is URL encoded and returns error message if it is
    /// CZ: Zkontroluje zda je hodnota parametru URL-enkódovaná a vrátí chybovou zprávu pokud ano
    /// </summary>
    /// <param name="before">Prefix text for the error message</param>
    /// <param name="value">Parameter value to check</param>
    /// <param name="parameterName">Name of the parameter being checked</param>
    /// <returns>Error message if value is URL encoded, null otherwise</returns>
    internal static string? InvalidParameter(string before, string value, string parameterName)
    {
        return value != WebUtility.UrlDecode(value)
        ? CheckBefore(before) + value + " is url encoded " + parameterName
        : null;
    }
}
