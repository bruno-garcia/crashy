namespace Crashy;

internal static class Thrower
{
    public static void ThrowException(string message) => throw new Exception(message);
}