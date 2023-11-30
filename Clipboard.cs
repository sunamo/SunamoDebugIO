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
                return SH.GetLines(Clipboard.ToString());
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
            Clipboard = SH.JoinNL(value);
        }
    }

    /// <summary>
    /// I like IList
    /// </summary>
    public static List<int> ClipboardIInt
    {
        set
        {
            Clipboard = SH.JoinNL(CA.ToListString2( value));
        }
    }

    /// <summary>
    /// If value is Enumerable, join with comma
    /// </summary>
    public static object Clipboard
    {
        get
        {
            return ClipboardHelper.GetText();
        }
        set
        {
            if (value != null)
            {
                string text = null;
                text = SH.ListToString(value);
                ClipboardHelper.SetText(text);
            }
        }
    }
}
