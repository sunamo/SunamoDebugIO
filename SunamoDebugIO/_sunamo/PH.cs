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
        using (Process myProcess = new Process())
        {
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.FileName = app;
            myProcess.StartInfo.Arguments = args;
            myProcess.StartInfo.CreateNoWindow = true;
            myProcess.Start();
        }
    }

    /// <summary>
    /// EN: Opens a file in VSCodium editor after a short delay
    /// CZ: Otevře soubor v editoru VSCodium po krátké prodlevě
    /// </summary>
    /// <param name="filePath">Path to the file to open</param>
    internal static void Codium(string filePath)
    {
        Thread.Sleep(100);
        if (string.IsNullOrWhiteSpace(filePath))
        {
            ThrowEx.InvalidParameter(filePath, "filePath");
        }
        PH.Open(CodiumExe, filePath);
    }
}
