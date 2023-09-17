
### Mac

Run the sample with:

```
rm -rf bin obj ../Crashy.Samples.Console/bin ../Crashy.Samples.Console/obj && \
    dotnet build -f net7.0-macos && \
    bin/Debug/net7.0-macos/osx-x64/Crashy.Samples.Console.app/Contents/MacOS/Crashy.Samples.Console 
```

That's because `dotnet run` can fail to run with: 

```
EXC_BAD_ACCESS (SIGKILL (Code Signature Invalid))
Namespace CODESIGNING, Code 2 Invalid Page
```
