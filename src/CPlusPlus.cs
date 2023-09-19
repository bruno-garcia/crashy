using System.Runtime.InteropServices;

namespace Crashy;

/// <summary>
/// Crashes and errors from C++.
/// </summary>
public static class CPlusPlus
{
    /// <summary>
    /// Methods that will crash an app through calling into C++ through C ABI.
    /// </summary>
    public static class Crash
    {
        /// <summary>
        /// Call into a function that throws a C++ exception.
        /// </summary>
        /// <example>
        /// libc++abi: terminating due to uncaught exception of type std::out_of_range: basic_string
        /// </example>
        [DllImport("libCrashyCpp", EntryPoint = "throwException")]
        public static extern void ThrowSubstrLengthException();

        /// <summary>
        /// P/Invokes into a function written in C++ that segfaults.
        /// </summary>
        /// <example>
        /// zsh: segmentation fault
        /// </example>
        [DllImport("libCrashyCpp", EntryPoint = "segfault")]
        public static extern void SegmentationFault();
    }
}
