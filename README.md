# IconExtractor

## Summary / 概要

This is a class library on .NET Framework 4.  
これは .NET Framework 4 上のクラスライブラリです。

This library allows you to extracting first .ico file from Win32 resource in PE format file (.exe, .dll), and write it to stream.  
このライブラリは、PEフォーマットファイル(.exe, .dll) 中の Win32 リソースから一つ目の .ico ファイルを抽出して、stream に書き込むことができます。

This library work well on Microsoft Azure Web Apps (old name is "Azure Websites").  
このライブラリは Microsoft Azure Web Apps (旧称 "Azure Websites") 上でも動作します。

## How to install? / インストール方法

You can install this library via NuGet package manager console.  
NuGet パッケージマネージャコンソール経由でインストールできます。

```
PM> Install-Package IconExtractor
```

## How to use? / 使い方

You can extract only one .ico file from PE format file (.exe, .dll) into stream by `Extract1stIconTo` static method live in `Toolbelt.Drawing.IconExtractor` class.

`Toolbelt.Drawing.IconExtractor` クラスの`Extract1stIconTo` 静的メソッドによって、PEフォーマットファイル(.exe, .dll) 中の一つ目の .ico ファイルだけを抽出して、stream に書き込むことができます。

```cs
using Toolbelt.Drawing;
...
var source = @"C:\Foo\Bar.exe";
using (var s = new FileStream(@"C:\Foo\Bar.ico", FileMode.Create))
    IconExtractor.Extract1stIconTo(source, s);
```
