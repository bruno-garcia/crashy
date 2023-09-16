namespace Crashy;

public static class CSharp
{
    /// <summary>
    /// Methods that will crash your application via C#.
    /// Crashes will happen in manage code.
    /// </summary>
    public static class Crash
    {
        /// <summary>
        /// Throws an exception from within a non-background <see cref="Thread"/>.
        /// </summary>
        public static void ThrowOnNonBackgroundThread()
        {
            var thread = new Thread(() => Thrower.ThrowException("Throw from a non-background thread."))
                { IsBackground = false };
            thread.Start();
            thread.Join();
        }

        /// <summary>
        /// Throws an exception from a <see cref="Task.Run(Action)"/> while blocking with <see cref="Task.Wait()"/>.
        /// </summary>
        public static void ThrowOnTaskRunAndWait() =>
            Task.Run(() => Thrower.ThrowException("Throw from Task.Run and block wait.")).Wait();


        /// <summary>
        /// Throws an exception from a <see cref="Task.Run(Action)"/> and returns the task for the caller.
        /// </summary>
        public static async Task ThrowOnTaskRun() =>
            await Task.Run(() => Thrower.ThrowException("Throw from Task.Run and await task."));

    }

    /// <summary>
    /// Errors that will not crash the application.
    /// </summary>
    public static class NonFatal
    {
        /// <summary>
        /// Throws an exception on a Task while not observing its result.
        /// </summary>
        /// <remarks>
        /// Such error doesn't terminate the process starting from .NET Framework 4.0
        /// It takes a few seconds because GC must be forced a few times until the finalizer thread picks up on the task.
        /// </remarks>
        /// <seealso href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskscheduler.unobservedtaskexception"/>
        public static void ThrowUnobservedTaskException()
        {
            var evt = new ManualResetEvent(false);
            EventHandler<UnobservedTaskExceptionEventArgs> subscription = (_, _) => evt.Set();
            TaskScheduler.UnobservedTaskException += subscription;
            try
            {
                var action = void () =>
                    _ = Task.Run(() => Thrower.ThrowException("Unobserved exception from a Task"));
                action.Invoke();
                var i = 5;
                do
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    if (evt.WaitOne(1000))
                    {
                        Console.WriteLine("TaskScheduler.UnobservedTaskException fired.");
                        return;
                    }
                } while (i-- > 0);

                Console.WriteLine("Something didn't work. No unobserved task exception happened.");
            }
            finally
            {
                TaskScheduler.UnobservedTaskException -= subscription;
            }
        }
    }
}