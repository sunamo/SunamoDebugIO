namespace SunamoDebugIO._sunamo;
public class FS
{
    //public static Action<string> CreateFileIfDoesntExists;

    public static async Task CreateFileIfDoesntExists(String path)
    {
        await File.AppendAllTextAsync(path, string.Empty);

        //foreach (var item in path)
        //{
        //    await File.AppendAllTextAsync(item, string.Empty);
        //}
    }
}
