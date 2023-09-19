Console.WriteLine("Let's crash!");

Crashy.Rust.Crash.Panic();

// Crashy.CPlusPlus.Crash.SegmentationFault();
// Crashy.CPlusPlus.Crash.ThrowSubstrLengthException();

#if MACOS
// Crashy.ObjectiveC.Crash.ThrowObjectiveCException();
// Crashy.ObjectiveC.Crash.SegmentationFault();
#endif

// Crashy.CSharp.NonFatal.ThrowUnobservedTaskException();
// Crashy.CSharp.Crash.ThrowOnNonBackgroundThread();
// await Crashy.CSharp.Crash.ThrowOnTaskRun();
// Crashy.CSharp.Crash.ThrowOnTaskRunAndWait();

Console.WriteLine("Still here... Press any key to exit.");
Console.ReadKey();