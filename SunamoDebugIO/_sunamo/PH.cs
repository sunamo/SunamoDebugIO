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
    internal static void Codium(string defFile)
    {
        Thread.Sleep(100);
        if (string.IsNullOrWhiteSpace(defFile))
        {
            ThrowEx.InvalidParameter(defFile, "defFile");
        }
        PH.Open(CodiumExe, defFile);
    }
}