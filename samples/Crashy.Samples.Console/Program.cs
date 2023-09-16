Console.WriteLine("Let's crash!");

Crashy.CSharp.NonFatal.ThrowUnobservedTaskException();
// Crashy.CSharp.Crash.ThrowOnNonBackgroundThread();
// await Crashy.CSharp.Crash.ThrowOnTaskRun();
// Crashy.CSharp.Crash.ThrowOnTaskRunAndWait();

Console.WriteLine("Still here... Press any key to exit.");
Console.ReadKey();