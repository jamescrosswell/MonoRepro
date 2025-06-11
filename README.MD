This repo illustrates an issue that occurs after installing the .NET SDK 9.0.300, when using mono to run unit tests on
in a solution with .NET Framework projects.

The problem occurs when the assembly being tested references a different version of the .NET Framework than the one 
being used by the test runner. In this example, the `MonoRepro.csproj` file targets `net462`, while the 
`MonoRepro.Tests.csproj` targets `net48`.

This was not a problem in .NET SDK 9.0.204 and earlier. You can see an example of a much more complex solution that has
different versions of the .NET Framework in the SDK and test projects in the sentry-dotnet repository (where this issue
was first discovered). Version 5.10.0 of the Sentry SDK is targeting `net462`, while the tests for the same version are
targeting `net48` (just as in this minimal repro).