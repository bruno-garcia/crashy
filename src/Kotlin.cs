#if __MOBILE__
namespace Crashy;

/// <summary>
/// Kotlin methods running in the Android Runtime, accessed via C#.
/// </summary>
public static class Kotlin
{
    /// <summary>
    /// Methods that will crash an app through calling into Kotlin.
    /// </summary>
    public static class Crash
    {
        /// <summary>
        /// Invokes a function written in Kotlin which throws an exception.
        /// </summary>
        /// <example>
        /// Example logcat output:
        ///  Caused by: java.lang.Exception: Kotlin: throwing exception.
        ///  	at com.brunogarcia.crashy.kotlin.Crashy.throw(Crashy.kt:9)
        ///  	at crc64109ccc1b8ccc3cfb.MainActivity.n_onCreate(Native Method)
        ///  	at crc64109ccc1b8ccc3cfb.MainActivity.onCreate(MainActivity.java:30)
        ///  	at android.app.Activity.performCreate(Activity.java:8595)
        ///  	at android.app.Activity.performCreate(Activity.java:8573)
        ///  	at android.app.Instrumentation.callActivityOnCreate(Instrumentation.java:1456)
        ///  	at android.app.ActivityThread.performLaunchActivity(ActivityThread.java:3764)
        ///  	... 12 more
        /// </example>
        public static void ThrowException() => Com.Brunogarcia.Crashy.Kotlin.Crashy.Throw();

        /// <summary>
        /// Invokes a function written in Kotlin which throws an exception on a background thread.
        /// </summary>
        /// <example>
        /// Example logcat output:
        /// A  Build fingerprint: 'google/sdk_gphone64_arm64/emu64a:14/UPB5.230623.003/10615560:user/release-keys'
        /// A  Revision: '0'
        /// A  ABI: 'arm64'
        /// A  Timestamp: 2023-09-16 23:21:09.040779618-0400
        /// A  Process uptime: 1s
        /// A  Cmdline: com.brunogarcia.crashy.samples.android
        /// A  pid: 22075, tid: 22100, name: Thread-3  &amp;gt;&amp;gt;&amp;gt; com.brunogarcia.crashy.samples.android &amp;lt;&amp;lt;&amp;lt;
        /// A  uid: 10188
        /// A  tagged_addr_ctrl: 0000000000000001 (PR_TAGGED_ADDR_ENABLE)
        /// A  pac_enabled_keys: 000000000000000f (PR_PAC_APIAKEY, PR_PAC_APIBKEY, PR_PAC_APDAKEY, PR_PAC_APDBKEY)
        /// A  signal 11 (SIGSEGV), code 1 (SEGV_MAPERR), fault addr 0x0000000000000078
        /// A  Cause: null pointer dereference
        /// A      x0  0000007008bfa6f8  x1  0000007008bfa7c0  x2  0000007016e19f08  x3  0000007008bfa99c
        /// A      x4  0000007008bf9530  x5  0000000070f97f70  x6  0000007008bf96d0  x7  00000000711b43e0
        /// A      x8  0000007008bfa7c0  x9  00000000000004b0  x10 0000000000000001  x11 0000000000000000
        /// A      x12 000000000000af47  x13 9676c976c1769b2b  x14 ffffffffffffffff  x15 000000733f2b0a70
        /// A      x16 0000007013780468  x17 0000007337d08280  x18 0000007004d8a000  x19 0000007008bfa6f8
        /// A      x20 0000007008bfa7c0  x21 0000000000000000  x22 00000000000000c8  x23 0000000000000002
        /// A      x24 0000007008bfa9e0  x25 000000731fead6c0  x26 0000007008bfaa30  x27 000000731feafbe8
        /// A      x28 0000007008bfa8b0  x29 0000007008bfa740
        /// A      lr  000000701366e68c  sp  0000007008bfa6f0  pc  000000701366e6f8  pst 0000000020001000
        /// A  28 total frames
        /// A  backtrace:
        /// A        #00 pc 00000000001f46f8  /data/app/~~9RxWNAQjUcAlwlAj0kIOxw==/com.brunogarcia.crashy.samples.android-gZYif90r8pU3qhWD2EEvcg==/lib/arm64/libmonosgen-2.0.so (BuildId: 52812271e2ea141c4ee822ccadaad7c1d4fe3bb5)
        /// A        #01 pc 00000000001f4534  /data/app/~~9RxWNAQjUcAlwlAj0kIOxw==/com.brunogarcia.crashy.samples.android-gZYif90r8pU3qhWD2EEvcg==/lib/arm64/libmonosgen-2.0.so (BuildId: 52812271e2ea141c4ee822ccadaad7c1d4fe3bb5)
        /// A        #02 pc 00000000001fe1e8  /data/app/~~9RxWNAQjUcAlwlAj0kIOxw==/com.brunogarcia.crashy.samples.android-gZYif90r8pU3qhWD2EEvcg==/lib/arm64/libmonosgen-2.0.so (mono_assembly_name_new+36) (BuildId: 52812271e2ea141c4ee822ccadaad7c1d4fe3bb5)
        /// A        #03 pc 00000000000415ac  /data/app/~~9RxWNAQjUcAlwlAj0kIOxw==/com.brunogarcia.crashy.samples.android-gZYif90r8pU3qhWD2EEvcg==/lib/arm64/libmonodroid.so (xamarin::android::Util::monodroid_load_assembly(void*, char const*)+44) (BuildId: eac3a89baabe3ca8bb61fba1e72e3966938d7cd0)
        /// A        #04 pc 0000000000036c14  /data/app/~~9RxWNAQjUcAlwlAj0kIOxw==/com.brunogarcia.crashy.samples.android-gZYif90r8pU3qhWD2EEvcg==/lib/arm64/libmonodroid.so (Java_mono_android_Runtime_propagateUncaughtException+64) (BuildId: eac3a89baabe3ca8bb61fba1e72e3966938d7cd0)
        /// A        #05 pc 0000000000376e30  /apex/com.android.art/lib64/libart.so (art_quick_generic_jni_trampoline+144) (BuildId: b221ddf9493596dec8a84b0692083bef)
        /// A        #06 pc 0000000000360680  /apex/com.android.art/lib64/libart.so (art_quick_invoke_static_stub+640) (BuildId: b221ddf9493596dec8a84b0692083bef)
        /// A        #07 pc 0000000000490424  /apex/com.android.art/lib64/libart.so (bool art::interpreter::DoCall&amp;lt;false&amp;gt;(art::ArtMethod*, art::Thread*, art::ShadowFrame&amp;, art::Instruction const*, unsigned short, bool, art::JValue*)+1136) (BuildId: b221ddf9493596dec8a84b0692083bef)
        /// A        #08 pc 000000000050a0e0  /apex/com.android.art/lib64/libart.so (void art::interpreter::ExecuteSwitchImplCpp&amp;lt;false&amp;gt;(art::interpreter::SwitchImplContext*)+1648) (BuildId: b221ddf9493596dec8a84b0692083bef)
        /// A        #09 pc 00000000003795d8  /apex/com.android.art/lib64/libart.so (ExecuteSwitchImplAsm+8) (BuildId: b221ddf9493596dec8a84b0692083bef)
        /// A        #10 pc 000000000022e054  &amp;lt;anonymous:7016729000&amp;gt; (mono.android.XamarinUncaughtExceptionHandler.uncaughtException+0)
        /// A        #11 pc 000000000037cbfc  /apex/com.android.art/lib64/libart.so (art::interpreter::Execute(art::Thread*, art::CodeItemDataAccessor const&amp;, art::ShadowFrame&amp;, art::JValue, bool, bool) (.__uniq.112435418011751916792819755956732575238.llvm.13156664521685854434)+356) (BuildId: b221ddf9493596dec8a84b0692083bef)
        /// A        #12 pc 000000000037c3dc  /apex/com.android.art/lib64/libart.so (artQuickToInterpreterBridge+788) (BuildId: b221ddf9493596dec8a84b0692083bef)
        /// A        #13 pc 0000000000376f68  /apex/com.android.art/lib64/libart.so (art_quick_to_interpreter_bridge+88) (BuildId: b221ddf9493596dec8a84b0692083bef)
        /// A        #14 pc 000000000058b954  /apex/com.android.art/lib64/libart.so (nterp_helper+7636) (BuildId: b221ddf9493596dec8a84b0692083bef)
        /// A        #15 pc 000000000010d964  /apex/com.android.art/javalib/core-oj.jar (java.lang.ThreadGroup.uncaughtException+28)
        /// A        #16 pc 000000000058aad4  /apex/com.android.art/lib64/libart.so (nterp_helper+3924) (BuildId: b221ddf9493596dec8a84b0692083bef)
        /// A        #17 pc 000000000010d950  /apex/com.android.art/javalib/core-oj.jar (java.lang.ThreadGroup.uncaughtException+8)
        /// A        #18 pc 000000000058b8f4  /apex/com.android.art/lib64/libart.so (nterp_helper+7540) (BuildId: b221ddf9493596dec8a84b0692083bef)
        /// A        #19 pc 000000000010eb1e  /apex/com.android.art/javalib/core-oj.jar (java.lang.Thread.dispatchUncaughtException+30)
        /// A        #20 pc 00000000003603a4  /apex/com.android.art/lib64/libart.so (art_quick_invoke_stub+612) (BuildId: b221ddf9493596dec8a84b0692083bef)
        /// A        #21 pc 000000000034b6d0  /apex/com.android.art/lib64/libart.so (art::ArtMethod::Invoke(art::Thread*, unsigned int*, unsigned int, art::JValue*, char const*)+144) (BuildId: b221ddf9493596dec8a84b0692083bef)
        /// A        #22 pc 000000000033256c  /apex/com.android.art/lib64/libart.so (art::detail::ShortyTraits&amp;lt;(char)86&amp;gt;::Type art::ArtMethod::InvokeInstance&amp;lt;(char)86, (char)76&amp;gt;(art::Thread*, art::ObjPtr&amp;lt;art::mirror::Object&amp;gt;, art::detail::ShortyTraits&amp;lt;(char)76&amp;gt;::Type)+68) (BuildId: b221ddf9493596dec8a84b0692083bef)
        /// A        #23 pc 00000000003feeb8  /apex/com.android.art/lib64/libart.so (art::Thread::Destroy(bool)+1736) (BuildId: b221ddf9493596dec8a84b0692083bef)
        /// A        #24 pc 00000000003fd358  /apex/com.android.art/lib64/libart.so (art::ThreadList::Unregister(art::Thread*, bool)+144) (BuildId: b221ddf9493596dec8a84b0692083bef)
        /// A        #25 pc 00000000004f3c28  /apex/com.android.art/lib64/libart.so (art::Thread::CreateCallback(void*)+1932) (BuildId: b221ddf9493596dec8a84b0692083bef)
        /// A        #26 pc 00000000000be6a8  /apex/com.android.runtime/lib64/bionic/libc.so (__pthread_start(void*)+208) (BuildId: c74277f481a383c87215b672f6465e24)
        /// A        #27 pc 000000000005b21c  /apex/com.android.runtime/lib64/bionic/libc.so (__start_thread+64) (BuildId: c74277f481a383c87215b672f6465e24)
        /// E  Tombstone written to: tombstone_02
        /// </example>
        public static void ThrowOnBackgroundThread() => Com.Brunogarcia.Crashy.Kotlin.Crashy.ThrowOnBackgroundThread();
    }
}
#endif