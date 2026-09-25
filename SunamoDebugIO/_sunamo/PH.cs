namespace SunamoDebugIO._sunamo;

internal class PH
{
    const string CodiumExe = "VSCodium.exe";

    private static void Open(string app, string args)
    {
        using var process = new Process();
        process.StartInfo.UseShellExecute = true;
        process.StartInfo.FileName = app;
        process.StartInfo.Arguments = args;
        process.StartInfo.CreateNoWindow = true;
        process.Start();
    }

    private static readonly string[] CodiumCandidatePaths =
    [
        @"C:\Program Files\VSCodium\VSCodium.exe",
        @"C:\Program Files (x86)\VSCodium\VSCodium.exe",
        System.IO.Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            @"Programs\VSCodium\VSCodium.exe"),
    ];

    internal static void Codium(string filePath)
    {
        Thread.Sleep(100);
        if (string.IsNullOrWhiteSpace(filePath))
        {
            ThrowEx.InvalidParameter(filePath, "filePath");
        }
        try
        {
            PH.Open(CodiumExe, filePath);
        }
        catch (System.ComponentModel.Win32Exception)
        {
            // VSCodium not in PATH — try known install locations
            var fullPath = CodiumCandidatePaths.FirstOrDefault(File.Exists);
            if (fullPath != null)
                PH.Open(fullPath, filePath);
            else
                Console.WriteLine($"VSCodium not found. File saved at: {filePath}");
        }
    }
}
