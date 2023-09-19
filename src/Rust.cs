using System.Runtime.InteropServices;

namespace Crashy;

/// <summary>
/// Crashes from Rust
/// </summary>
public static class Rust
{
    /// <summary>
    /// Methods that invoke Rust functions that crash the app.
    /// </summary>
    public static class Crash
    {
        /// <summary>
        /// P/Invokes into a Rust function that panics.
        /// </summary>
        /// <example>
        /// thread '&lt;unnamed&gt;' panicked at 'panic: "crash me plz!"', src/lib.rs:7:5
        /// note: run with `RUST_BACKTRACE=1` environment variable to display a backtrace
        /// fatal runtime error: failed to initiate panic, error 5
        /// zsh: abort      RUST=BACKTRACE=1
        /// </example>
        /// <seealso href="https://doc.rust-lang.org/std/macro.panic.html"/>
        public static void Panic() => Panic("crash me plz!");

        [DllImport("libcrashy_rust", EntryPoint = "panicky")]
        private static extern void Panic(string? message);
    }
}