namespace SunamoDebugIO._sunamo;
internal class FS
{
    //internal static Action<string> CreateFileIfDoesntExists;

    internal static async Task CreateFileIfDoesntExists(String path)
    {
        await File.AppendAllTextAsync(path, string.Empty);

        //foreach (var item in path)
        //{
        //    await File.AppendAllTextAsync(item, string.Empty);
        //}
    }
}
