namespace SunamoDebugIO;

public partial class ProgramShared
{


    public static
#if ASYNC
    async Task<string>
#else
    string
#endif
 Input()
    {

        return
#if ASYNC
    await
#endif
 TF.ReadAllText(inputFile);

    }

    public static
#if ASYNC
    async Task<List<string>>
#else
    List<string>
#endif
 InputL()
    {

        return
#if ASYNC
await
#endif
TF.ReadAllLines(inputFile);

    }

    public static
#if ASYNC
    async Task<string>
#else
    string
#endif
    InputJson()
    {

        return
#if ASYNC
await
#endif
TF.ReadAllText(inputFileJson);

    }
}
