#if MACOS
using System.Runtime.InteropServices;

namespace Crashy;

/// <summary>
/// Crashes and errors from Objective-C.
/// </summary>
public static class ObjectiveC
{
    /// <summary>
    /// Methods written in Objective-C that will crash your application.
    /// These are native crashes.
    /// </summary>
    public static class Crash
    {
        /// <summary>
        /// P/Invokes into a function written in Objective-C that segfaults.
        /// </summary>
        /// <example>
        /// Let's crash!
        /// 2023-09-16 20:57:31.775 Crashy.Samples.Console[60171:9683148] Objective-C: Crashing
        /// zsh: segmentation fault
        /// </example>
        [DllImport("libCrashyObjc", EntryPoint = "segfault")]
        public static extern void SegmentationFault();

        /// <summary>
        /// P/Invokes into a function written in Objective-C that throws an Objective-C exception.
        /// </summary>
        /// <example>
        /// 2023-09-16 20:55:02.720 Crashy.Samples.Console[60007:9680091] Objective-C: Throwing an Exception
        /// 2023-09-16 20:55:02.728 Crashy.Samples.Console[60007:9680091] *** Terminating app due to uncaught exception 'Objective-C Exception', reason: 'Testing crashes.'
        /// *** First throw call stack:
        /// (
        /// 0   CoreFoundation                      0x00007ff80bdb7cb3 __exceptionPreprocess + 242
        /// 1   libobjc.A.dylib                     0x00007ff80b90610a objc_exception_throw + 48
        /// 2   libCrashyObjc.dylib                 0x0000000109a8eec6 throwObjectiveCException + 70
        /// 3   ???                                 0x0000000114827743 0x0 + 4639061827
        /// 4   ???                                 0x0000000114825b65 0x0 + 4639054693
        /// 5   libcoreclr.dylib                    0x000000010add6f79 CallDescrWorkerInternal + 124
        /// 6   libcoreclr.dylib                    0x000000010ac28862 _ZN18MethodDescCallSite16CallTargetWorkerEPKmPmi + 1522
        /// 7   libcoreclr.dylib                    0x000000010ab1a18e _Z7RunMainP10MethodDescsPiPP8PtrArray + 734
        /// 8   libcoreclr.dylib                    0x000000010ab1a4c5 _ZN8Assembly17ExecuteMainMethodEPP8PtrArrayi + 421
        /// 9   libcoreclr.dylib                    0x000000010ab44bdb _ZN8CorHost215ExecuteAssemblyEjPKDsiPS1_Pj + 619
        /// 10  libcoreclr.dylib                    0x000000010ab06684 coreclr_execute_assembly + 196
        /// 11  Crashy.Samples.Console              0x0000000100d66887 mono_jit_exec + 167
        /// 12  Crashy.Samples.Console              0x0000000100d6a2af xamarin_main + 815
        /// 13  Crashy.Samples.Console              0x0000000100dfd054 main + 52
        /// 14  dyld                                0x000000020143a310 start + 2432
        /// )
        /// libc++abi: terminate_handler unexpectedly threw an exception
        /// </example>
        [DllImport("libCrashyObjc", EntryPoint = "throwObjectiveCException")]
        public static extern void ThrowObjectiveCException();
    }
}
#endif