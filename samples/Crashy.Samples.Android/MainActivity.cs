namespace Crashy.Samples.Android;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        SetContentView(Resource.Layout.activity_main);

        Crashy.Kotlin.Crash.ThrowOnBackgroundThread();

        // Crashy.Kotlin.Crash.ThrowException();

        // Crashy.CSharp.Crash.ThrowOnNonBackgroundThread();
    }
}