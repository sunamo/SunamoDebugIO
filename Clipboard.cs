namespace SunamoDebugIO;


public partial class ProgramShared
{
    public static string ClipboardS
    {
        get
        {
            return Clipboard.ToString();
        }
    }

    public static List<string> ClipboardL
    {
        get
        {
            if (Clipboard != null)
            {
                return SHGetLines.GetLines(Clipboard.ToString());
            }
            return new List<string>();
        }
        set
        {
            ClipboardI = value;
        }
    }

    /// <summary>
    /// I like IList
    /// </summary>
    public static List<string> ClipboardI
    {
        set
        {
            Clipboard = SHJoin.JoinNL(value);
        }
    }

    /// <summary>
    /// I like IList
    /// </summary>
    public static List<int> ClipboardIInt
    {
        set
        {
            Clipboard = SHJoin.JoinNL(value.ConvertAll(d => d.ToString()));
        }
    }

    /// <summary>
    /// If value is Enumerable, join with comma
    /// </summary>
    public static string Clipboard
    {
        get
        {
            return ClipboardService.GetText();
        }
        set
        {
            ClipboardService.SetText(value);
        }
    }
}
