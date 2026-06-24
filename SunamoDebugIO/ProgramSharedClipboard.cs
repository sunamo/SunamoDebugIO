namespace SunamoDebugIO;

public partial class ProgramShared
{
    public static List<int> ClipboardIInt
    {
        set => Clipboard = string.Join(Environment.NewLine, value.ConvertAll(number => number.ToString()));
    }

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
                var value = Clipboard;
                return value.Split(new[] { value.Contains("\r\n") ? "\r\n" : "\n" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }

            return new List<string>();
        }
        set => Clipboard = string.Join(Environment.NewLine, value);
    }

    public static List<int> ClipboardLInt
    {
        set { Clipboard = string.Join(Environment.NewLine, value.ConvertAll(number => number.ToString())); }
    }

    public static string? Clipboard
    {
        get => ClipboardService.GetText();
        set => ClipboardService.SetText(value ?? "");
    }


}
