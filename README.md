<img src=".github/logo.png" alt="Crashy" width="200"/> 

# Crashy

A .NET library with a series of ways to crash an application.
Particularly native crashes for different platforms.
This library is useful to test your crash reporting service.

Via .NET, you an trigger crashes such as:

### Managed

* C# exceptions on a non-background thread
* C# exception throw from a task
* Unobserved task exception (non fatal)

### Android

* Kotlin exception on a background thread
* Kotlin exception thrown - can be caught in C#

### macOS

* Objective-C exception
* C++ exception
* Segmentation fault (C++ and Objective-C libs)

## Acknowledgements

* Icon [made by Marissa Coffey, Noun Project](https://thenounproject.com/icon/burned-power-supply-5551200/).
