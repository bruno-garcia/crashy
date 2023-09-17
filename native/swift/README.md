Compiling:

TODO: Only compiling arm64 (on my M1)

```
rm libCrashySwift.dylib
rm -rf libCrashySwift.dylib.dSYM

swift build -c release --arch arm64 --arch x86_64 && \

mv .build/apple/Products/Release/libCrashySwift.dylib . && \
mv .build/apple/Products/Release/libCrashySwift.dylib.dSYM .
```