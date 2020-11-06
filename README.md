# ![package icon](https://raw.githubusercontent.com/jsakamoto/IconExtractor/master/.assets/nupkg-icon.png) IconExtractor [![NuGet Package](https://img.shields.io/nuget/v/IconExtractor.svg)](https://www.nuget.org/packages/IconExtractor/)

## Summary

This is a class library for .NET Framework 4. and .NET Core on Windows OS. 

This library allows you to extract first .ico file from Win32 resource in PE format file (.exe, .dll) to a stream.

This library also works well on Microsoft Azure App Services (but **Windows Operating System only**).

_**Notice:** This is a .NET Standard 2.0 class library, but **this doesn't work on Linux and macOS**, because this library includes many Win32 API calls via P/Invoke._

## How to install?

You can install this library via the NuGet package manager console.

```
PM> Install-Package IconExtractor
```

You can also install this library via dotnet CLI.

```shell
$ dotnet add package IconExtractor
```

## How to use?

You can extract only one .ico file from PE format file (.exe, .dll) into stream by `Extract1stIconTo` static method live in `Toolbelt.Drawing.IconExtractor` class.

```cs
using Toolbelt.Drawing;
...
var source = @"C:\Foo\Bar.exe";
using var s = File.Create(@"C:\Foo\Bar.ico");
IconExtractor.Extract1stIconTo(source, s);
```

## License

[GNU Lesser General Public License v3.0](https://github.com/jsakamoto/IconExtractor/blob/master/LICENSE)
