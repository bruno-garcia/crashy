#if __MOBILE__
namespace Crashy;

public static class Kotlin
{
    public static class Crash
    {
        public static void ThrowException()
        {
            Com.Brunogarcia.Crashy.Kotlin.Crashy.Throw();
        }

        public static void ThrowOnBackgroundThread()
        {
            Com.Brunogarcia.Crashy.Kotlin.Crashy.ThrowOnBackgroundThread();
        }
    }
}
#endif