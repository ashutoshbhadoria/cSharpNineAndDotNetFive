# Important Points

## Chapter 1 - Hello C#! Welcome, .NET

1. .NET Framework is a development framework that includes,
   1. .Common Language Runtime (CLR): Manages code execution.
   2. Base Class Library (BCL): Provides a rich library of classes to build applications from.
2. Intially designed to be cross-platform but eventually worked only on Windows.
3. Since .NET Framework 4.5.2 it has been an official component of Windows OS, it is updated infrequently.
4. All apps on a computer wrtitten for .NET Framework share the same version of the CLR and libraries stored in the Global Assembly Cache (GAC), which can lead to issues if some of them need a specifi version for compatibility.
5. Pratically speaking, .NET Framework is Windows-only and a legacy platform.
6. Third parties developed a cross platform .NET Framework application named the Mono project. It fell well behind the official implementation of .NET Framework.
7. Mono has found a niche as the foundation of the Xamarin mobile platform as well as cross-platform game development platforms like Unity.
8. Microsoft decoupled .NET from its close ties with Windows, rewrote the .NET Framework to be truly cross-platform, refactored and removed major parts that were no longer considered core and this new product was called .NET Core.
9. .NET Core has
   1. CoreCLR: A cross-platform implementation of CLR.
   2. CoreFX: Streamlined library of classes
10. .NET 5 would unify all platforms except mobile. In .NET 6 mobile will also be supported by the unified .NET platform.
11. LTS release will be supported for 3 years after general availability.
12. For current releases, after a 3-month maintenance period, the previous minor version will no longer be supported.
13. .NET Runtime follows semantic versioning, .NET SDK versioning does not follow semantic versioning. The major and minor version numbers are tied to the runtime version it is matched with.
14. List SDK and runtimes using
    1. `dotnet --list-sdks`
    2. `dotnet --list-runtimes`
15. .NET Core is smaller than .NET Framework as legacy and non-cross-platform technologies have been removed.
16. Windows Desktop Pack is included for Windows version of .NET 5.
17. ASP.NET Web Forms and Windows Communication Foundation (WCF) are old web application and service technologies and have been removed. ASP.NET MVC  and ASP.NET Web API have been refactored and combined into a platform that runs on .NET 5, named ASP.NET Core.
18. Entity Framework 6 has gained baggage over the years, so the cross-platform API has been slimmed down  and has been given a support for non-relational databases and has been named Entity Framework Core.
19. In addition to removing large pieces from .NET Framework in order to make .NET Core, Microsoft has componentized .NET into NuGet packages, those being small chunks of functionality that can be deployed independently.
20. The goal is to componentize .NET to support modern technologies and to have fewer dependencies, so that deployment requires only those packages that your application needs.
21. in 2019, .NET had three forked platforms
    1. .NET Framework
    2. .NET Core
    3. Xamarin
22. .NET Standard is a specification for a set of APIs that all .NET platforms could implement to indicate what level of compatibility they have.
23. The latest .NET Standard, 2.1, is only implemented by .NET Core 3.0, Mono, and Xamarin. Some features of C# 8.0 require .NET Standard 2.1. .NET Standard 2.1 is not implemented by .NET Framework 4.8 so we should treat .NET Framework as legacy.
24. By the end of 2021, Microsoft promises that there will be a single .NET platform.
25. .NET 6 is planned to have a single BCL and two runtimes: 
    1. One optimized for server or desktop scenarios like websites and Windows desktop apps based on the .NET Core runtime
    2. One optimized for mobile apps based on the Xamarin runtime.
26. The C# compiler (named Roslyn ) used by the dotnet CLI tool converts your C# source code into intermediate language ( IL ) code and stores the IL in an assembly (a DLL or EXE file).
27. Top level programs can be written in C# 9, only one per project is allowed.
28. Help commands
    1. `dotnet help new`
    2. `dotnet new console -h`
29. Search StackOverflow on DuckDuckGo as `!so securestring` and on Google as `garbage collection site:stackoverflow.com +C# -Java`


## Chapter 2 - Speaking C#

1. C# 1.0 (2002)
   1. Included all the important features of a statically typed object-oriented modern language.
2. C# 2.0 (2005)
   1. Focused on enabling strong data typing using Generics, to improve code performance and reduce type errors.
   2. Nullable value types.
3. C# 3.0 (2007)
   1. Enabled declarative coding with Language Integrated Queries (LINQ).
   2. Anonymous types. (implicitly typed variables)
   3. Lambda Functions.
4. C# 4.0 (2010)
   1. Focused on improving interoperability with dynamic languages.
   2. Dynamic Types.
   3. Named / Optional arguments.
5. C# 5.0 (2012)
   1. Focused on simplifying asynchronous operation support by automatically implementing complex state machines while writing what looks like synchronous statements.
6. C# 6.0 (2015)
   1. Static imports.
   2. Interpolated strings.
   3. Expression bodied members.
7. C# 7.0 (March 2017)
   1. Binary literals and digit separators.
   2. Pattern Matching.
   3. `out` variables.
   4. Tuples
   5. Local Functions
8. C# 7.1 (August 2017)
   1. Default literal expressions.
   2. Inferred tuple element names.
   3. async Main
9. C# 7.2 (November 2017)
   1.  Leading underscores in numeric literals.
   2.  Non-trailing named arguments.
   3.  `private protected` access modifier.
   4.  You can test `==` and `!=` with tuple types.
10. C# 7.3 (May 2019)
    1. Focused on performance-oriented safe code that improves ref variables, pointers, and stackalloc. 
11. C# 8.0 (September 2019)
    1.  Nullable reference types.
    2.  Switch expressions.
    3.  Default interface methods.
12. C# 9.0 (November 2020)
    1.  Minimal Code Console Apps (Top-level programs)
    2.  Enhanced pattern matching.
    3.  Records.
13. .NET SDK version -> `dotnet --version`
14. Supported language versions (run on developer cmd for VS2019) -> `csc -langversion:?`
15. Configuration can be added to the project file to indicate the language version -> `<LangVersion>7.3</LangVersion>`
16. Portential values for `LangVersion` are
    1.  Specific version number.
    2.  `latestmajor` - highest major version.
    3.  `latest` - highest major and minor version.
    4.  `preview` - highest available preview version.
17. Comments should never be the only way that you document your code. Choosing sensible names for variables and functions, writing unit tests, and creating literal documents are other ways to document your code.
18. Strictly speaking, C# doesn't define any types. Keywords such as string that look like types are aliases , which represent types provided by the platform on which C# runs.
19. In C# everything can be categorized as 
    1. class
    2. struct
    3. enum
    4. interface
    5. delegate
    6. record ??
20. You can output the name of a variable using a keyword introduced in C# 6.0 `nameof`
21. A literal is a notation that represents a fixed value.
22. String literals:
    1. Literal string : Characters enclosed in double-quote characters. They can use escape characters like \t for tab.
    2. Verbatim string : A literal string prefixed with @ to disable escape characters so that a backslash is a backslash.
    3. Interpolated string : A literal string prefixed with $ to enable embedded formatted variables. You will learn more about this later in this chapter.
23. Computers can always exactly represent integers using the `int` type or one of its sibling types such as `long` and `short`.
24. Computers cannot always exactly represent floating point numbers.
25. C# has an operator named `sizeof()` that returns the number of bytes that a type uses in memory.
26. A decimal variable uses 16 bytes of memory and can store big numbers, but not as big as a double type.
27. Never compare double values using `==`
28. The `decimal` type is accurate because it stores the number as a large integer and shifts the decimal point. For example, 0.1 is stored as 1, with a note to shift the decimal point one place to the left.
29. Use `int` for whole numbers and `double` for real numbers that will not be compared to other values. Use `decimal` for money, CAD drawings, general engineering, and wherever the accuracy of a real number is important.
30. The `double` type has some useful special values: `double.NaN` means not-a-number, double`.Epsilon` is the smallest positive number that can be stored in a double , and `double.Infinity` means an infinitely large value.
31. There is a special type named `object` that can store any type of data, but its flexibility comes at the cost of messier code and possibly poor performance. Avoid it whenever possible.
32. The `object` type has been available since the first version of C#, but C# 2.0 and later have a better alternative called `generics`.
33. There is another special type named `dynamic` that can also store any type of data, but even more than `object` , its flexibility comes at the cost of performance. Unlike `object` , the value stored in the variable can have its members invoked without an explicit cast.
34. One limitation of `dynamic` is that Visual Studio Code cannot show IntelliSense to help you write the code. This is because the compiler cannot check what the type is during build time. Instead, the CLR checks for the member at runtime and throws an exception if it is missing.
35. Local variables are declared inside methods, and they only exist during the execution of that method, and once the method returns, the memory allocated to any local variables is released.
36. Strictly speaking, value types are released while reference types must wait for a garbage collection.

