namespace SunamoDebugIO._sunamo;

internal class PH
{
    const string CodiumExe = "VSCodium.exe";
    static void Open(string app, string args)
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