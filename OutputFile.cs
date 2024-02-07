
namespace SunamoDebugIO;

using SunamoDebugIO._public;

using System;

public partial class ProgramShared
{
    public static string NotExistsFiles
    {
        set
        {
            WriteAllText(notExistsFile, value);
            //ThisApp.Success("Output was written to " + notExistsFile);
        }
    }

    public static string Output
    {
        set
        {
            WriteAllText(outputFile, value);
            //ThisApp.Success("Output was written to " + outputFile);
        }
    }

    public static string OutputJson
    {
        set
        {
            WriteAllText(outputJsonFile, value);
            //ThisApp.Success("Output was written to " + outputJsonFile);
        }
    }

    public static List<string> OutputL
    {
        set
        {
            WriteAllLines(outputFile, value);
            //ThisApp.Success("Output was written to " + outputFile);
        }
    }



    public static string Output2
    {
        set
        {
            WriteAllText(output2File, value);
            //ThisApp.Success("Output was written to " + output2File);
        }
    }

    private static void WriteAllText(string output2File, string value)
    {
        if (output2File == null)
        {
            throw new Exception("Firstly you have to call ProgramShared.CreatePathToFiles");
        }

        File.WriteAllText(output2File, value);
    }

    private static void WriteAllLines(string output2File, List<string> value)
    {
        if (output2File == null)
        {
            throw new Exception("Firstly you have to call ProgramShared.CreatePathToFiles");
        }

        File.WriteAllLines(output2File, value);
    }

    public static List<string> OutputL2
    {
        set
        {
            WriteAllLines(output2File, value);
            //ThisApp.Success("Output was written to " + output2File);
        }
    }



    public static async void Output2Open()
    {
        WarningIfIsNull();

        PHWinDebugIO.Codium(output2File).GetAwaiter().GetResult();
    }

    public static void OutputOpen()
    {
        WarningIfIsNull();

        PHWinDebugIO.Codium(outputFile).GetAwaiter().GetResult();
    }

    public static void OutputJsonOpen()
    {
        WarningIfIsNull();

        PHWinDebugIO.Codium(outputJsonFile).GetAwaiter().GetResult();
    }

    public static void InputOpen()
    {
        WarningIfIsNull();

        PHWinDebugIO.Codium(inputFile).GetAwaiter().GetResult();
    }

    private static void WarningIfIsNull()
    {
        if (PHWinDebugIO.Codium == null)
        {
            throw new Exception("Please set up PHWinDebugIO.Codium");
        }
    }
}
