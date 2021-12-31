namespace CliExitCodeProviderNS;

/// <summary>
///     Codes were taken from https://tldp.org/LDP/abs/html/exitcodes.html
/// </summary>
public static class CliExitCodeProvider
{
    public const int Success = 0;
    public const int CatchallForGeneralErrors = 1;
    public const int ScriptTerminatedByControlC = 130;
}