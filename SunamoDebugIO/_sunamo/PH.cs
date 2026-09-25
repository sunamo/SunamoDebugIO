namespace SunamoDebugIO._sunamo;

/// <summary>
/// EN: Process helper class for opening files in external applications
/// CZ: Pomocná třída pro otevírání souborů v externích aplikacích
/// </summary>
internal class PH
{
    /// <summary>
    /// EN: VSCodium executable name
    /// CZ: Název spustitelného souboru VSCodium
    /// </summary>
    const string CodiumExe = "VSCodium.exe";

    /// <summary>
    /// EN: Opens an application with specified arguments
    /// CZ: Otevře aplikaci se specifikovanými argumenty
    /// </summary>
    /// <param name="app">Application executable name or path</param>
    /// <param name="args">Command line arguments to pass to the application</param>
    private static void Open(string app, string args)
    {
        using var process = new Process();
        process.StartInfo.UseShellExecute = true;
        process.StartInfo.FileName = app;
        process.StartInfo.Arguments = args;
        process.StartInfo.CreateNoWindow = true;
        process.Start();
    }

    /// <summary>
    /// EN: Opens a file in VSCodium editor after a short delay
    /// CZ: Otevře soubor v editoru VSCodium po krátké prodlevě
    /// </summary>
    /// <param name="filePath">Path to the file to open</param>
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