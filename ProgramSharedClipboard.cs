namespace SunamoDebugIO;

public partial class ProgramShared
{
    #region MyRegion

    //public static string ClipboardS
    //{
    //    get
    //    {
    //        return Clipboard.ToString();
    //    }
    //}

    public static List<int> ClipboardIInt
    {
        set => Clipboard = string.Join(Environment.NewLine, value.ConvertAll(d => d.ToString()));
    }

    #endregion

    /// <summary>
    ///     Může být na Object ale ne default (tedy s příponou O) a velkým O
    /// </summary>
    public static object ClipboardO
    {
        set => Clipboard = value.ToString();
    }

    public static List<string> ClipboardL
    {
        get
        {
            if (Clipboard != null)
            {
                var v = Clipboard;
                return v.Split(new[] { v.Contains("\r\n") ? "\r\n" : "\n" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                //return SHGetLines.GetLines(Clipboard.ToString());
            }

            return new List<string>();
        }
        set => Clipboard = string.Join(Environment.NewLine, value);
    }

    ///// <summary>
    ///// I like IList
    ///// </summary>
    //public static IList<string> ClipboardI
    //{
    //    set
    //    {
    //        Clipboard = string.Join(Environment.NewLine, value);
    //    }
    //}

    /// <summary>
    ///     I like IList
    /// </summary>
    public static List<int> ClipboardLInt
    {
        set { Clipboard = string.Join(Environment.NewLine, value.ConvertAll(d => d.ToString())); }
    }

    /// <summary>
    ///     If value is Enumerable, join with comma
    /// </summary>
    public static string? Clipboard
    {
        get => ClipboardService.GetText();
        set => ClipboardService.SetText(value ?? "");
    }


}