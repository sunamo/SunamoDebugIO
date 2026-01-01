namespace SunamoDebugIO;

/// <summary>
/// EN: Clipboard-related functionality for ProgramShared
/// CZ: Funkcionalita související se schránkou pro ProgramShared
/// </summary>
public partial class ProgramShared
{
    /// <summary>
    /// EN: Sets clipboard content from a list of integers, each on a new line
    /// CZ: Nastaví obsah schránky ze seznamu celých čísel, každé na novém řádku
    /// </summary>
    public static List<int> ClipboardIInt
    {
        set => Clipboard = string.Join(Environment.NewLine, value.ConvertAll(number => number.ToString()));
    }

    /// <summary>
    /// EN: Sets clipboard content from any object by calling ToString() on it. Can be used with Object but not default (with suffix O and capital O).
    /// CZ: Nastaví obsah schránky z jakéhokoliv objektu zavoláním ToString(). Může být použito s Object ale ne default (s příponou O a velkým O).
    /// </summary>
    public static object ClipboardO
    {
        set => Clipboard = value.ToString();
    }

    /// <summary>
    /// EN: Gets or sets clipboard content as a list of strings, splitting by newlines when getting
    /// CZ: Získá nebo nastaví obsah schránky jako seznam stringů, při získání rozdělí podle nových řádků
    /// </summary>
    public static List<string> ClipboardL
    {
        get
        {
            if (Clipboard != null)
            {
                var value = Clipboard;
                return value.Split(new[] { value.Contains("\r\n") ? "\r\n" : "\n" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }

            return new List<string>();
        }
        set => Clipboard = string.Join(Environment.NewLine, value);
    }

    /// <summary>
    /// EN: Sets clipboard content from a list of integers (IList interface), each on a new line
    /// CZ: Nastaví obsah schránky ze seznamu celých čísel (IList rozhraní), každé na novém řádku
    /// </summary>
    public static List<int> ClipboardLInt
    {
        set { Clipboard = string.Join(Environment.NewLine, value.ConvertAll(number => number.ToString())); }
    }

    /// <summary>
    /// EN: Gets or sets raw clipboard text content. If value is Enumerable, join with comma.
    /// CZ: Získá nebo nastaví surový textový obsah schránky. Pokud je hodnota Enumerable, spojí čárkou.
    /// </summary>
    public static string? Clipboard
    {
        get => ClipboardService.GetText();
        set => ClipboardService.SetText(value ?? "");
    }


}
