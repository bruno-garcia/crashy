Console.WriteLine("Let's crash!");

#if MACOS
// Crashy.ObjectiveC.Crash.CrashSwift();
// Crashy.ObjectiveC.Crash.ThrowObjectiveCException();
Crashy.ObjectiveC.Crash.SegmentationFault();
#endif

// Crashy.CSharp.NonFatal.ThrowUnobservedTaskException();
// Crashy.CSharp.Crash.ThrowOnNonBackgroundThread();
// await Crashy.CSharp.Crash.ThrowOnTaskRun();
// Crashy.CSharp.Crash.ThrowOnTaskRunAndWait();

Console.WriteLine("Still here... Press any key to exit.");
Console.ReadKey();