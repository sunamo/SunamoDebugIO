namespace SunamoDebugIO._sunamo.SunamoExceptions;

/// <summary>
/// EN: Helper class for throwing exceptions with detailed information
/// CZ: Pomocná třída pro vyhazování výjimek s detailními informacemi
/// </summary>
internal partial class ThrowEx
{
    /// <summary>
    /// EN: Validates parameter value and throws exception if it's URL encoded
    /// CZ: Validuje hodnotu parametru a vyhodí výjimku pokud je URL-enkódovaná
    /// </summary>
    /// <param name="value">Parameter value to validate</param>
    /// <param name="parameterName">Name of the parameter being validated</param>
    /// <returns>True if exception was thrown, false otherwise</returns>
    internal static bool InvalidParameter(string value, string parameterName)
    { return ThrowIsNotNull(Exceptions.InvalidParameter(FullNameOfExecutedCode(), value, parameterName)); }


    #region Other
    /// <summary>
    /// EN: Gets the full name of the currently executing code (type and method)
    /// CZ: Získá plný název aktuálně spuštěného kódu (typ a metoda)
    /// </summary>
    /// <returns>Full name in format Type.Method</returns>
    internal static string FullNameOfExecutedCode()
    {
        Tuple<string, string, string> placeOfException = Exceptions.PlaceOfException();
        string fullName = FullNameOfExecutedCode(placeOfException.Item1, placeOfException.Item2, true);
        return fullName;
    }

    /// <summary>
    /// EN: Constructs the full name of executed code from type and method name
    /// CZ: Sestaví plný název spuštěného kódu z typu a názvu metody
    /// </summary>
    /// <param name="type">Type object (can be Type, MethodBase, string, or other object)</param>
    /// <param name="methodName">Method name (optional)</param>
    /// <param name="isFromThrowEx">Whether this is called from ThrowEx class</param>
    /// <returns>Full name in format Type.Method</returns>
    static string FullNameOfExecutedCode(object type, string methodName, bool isFromThrowEx = false)
    {
        if (methodName == null)
        {
            int depth = 2;
            if (isFromThrowEx)
            {
                depth++;
            }

            methodName = Exceptions.CallingMethod(depth);
        }
        string typeFullName = "";
        if (type == null)
        {
            typeFullName = string.Empty;
        }
        else if (type is Type typeInstance)
        {
            typeFullName = typeInstance.FullName ?? "Type cannot be get via type is Type typeInstance";
        }
        else if (type is MethodBase method)
        {
            typeFullName = method.ReflectedType?.FullName ?? "Type cannot be get via type is MethodBase method";
            methodName = method.Name;
        }
        else if (type is string)
        {
            typeFullName = type.ToString() ?? "Type cannot be get via type is string";
        }
        else
        {
            Type actualType = type.GetType();
            typeFullName = actualType.FullName ?? "Type cannot be get via type.GetType()";
        }
        return string.Concat(typeFullName, ".", methodName);
    }

    /// <summary>
    /// EN: Throws exception if the exception message is not null
    /// CZ: Vyhodí výjimku pokud zpráva výjimky není null
    /// </summary>
    /// <param name="exception">Exception message to check</param>
    /// <param name="isReallyThrow">Whether to actually throw the exception (default true)</param>
    /// <returns>True if exception would be thrown, false otherwise</returns>
    internal static bool ThrowIsNotNull(string? exception, bool isReallyThrow = true)
    {
        if (exception != null)
        {
            Debugger.Break();
            if (isReallyThrow)
            {
                throw new Exception(exception);
            }
            return true;
        }
        return false;
    }
    #endregion
}
