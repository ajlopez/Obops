# Obops

Operators (add, subtract, negate, ...) for .NET objects, written in C#

Work in Progress

## Inception

[@martinsalias](http://twitter.com/martinsalias) detected that my [Mass interpreted language](https://github.com/ajlopez/Mass)
uses some operators implemented in Microsoft.VisualBasic assembly, but not implemented in Mono. And many
other of my interpreted languages uses such operators (notable, [AjGenesis](https://github.com/ajlopez/AjGenesis) runs in
Mono, with add, subtract, ... on arbitrary objects, but the VB.NET compiled code apparently doesn't use the missing
operators in Mono).

So, I started this project to implement methods like:

```c#
object Add(object a, object b);
object Subtract(object a, object b);
// ...
```

## References

- [Operator '!=' cannot be applied to operands of type 'T' and 'T'](http://stackoverflow.com/questions/8982645/operator-cannot-be-applied-to-operands-of-type-t-and-t)
- [Operator '+' cannot be applied to operands of type 'T' and 'T' ](http://social.msdn.microsoft.com/forums/en-US/csharplanguage/thread/6317290d-bbfb-46f6-812b-7f4252ce3f27/)
- [Creating a Math library using Generics in C#](http://stackoverflow.com/questions/63694/creating-a-math-library-using-generics-in-c-sharp)
- [How to Implement Generic Method to do Math calculations on different value types](http://stackoverflow.com/questions/814202/how-to-implement-generic-method-to-do-math-calculations-on-different-value-types)
- [Generic math function](http://social.msdn.microsoft.com/Forums/en-US/csharplanguage/thread/9787b8bb-1537-404b-af76-e1432f7fbfe4)
- [Generics Algorithms](http://blogs.msdn.com/b/ericgu/archive/2003/11/14/52852.aspx)
- [Using generics for calculations](http://www.codeproject.com/Articles/8531/Using-generics-for-calculations)

## Nuget References

- [Creating and Publishing a Package](http://docs.nuget.org/docs/creating-packages/creating-and-publishing-a-package)
- [NuGet.exe Command-Line Utility](http://nuget.codeplex.com/downloads/get/697144)
- [Nuget Releases](http://nuget.codeplex.com/releases)
- [Nuget.org](http://www.nuget.org/)

I created the package from ObOps.csproj directory:

```
nuget spec
rem then edit spec
nuget pack ObOps.csproj -build -Prop Configuration=Release
nuget push ObObjs-0.0.1.nupkg
```

but the final version was using a .nupkg from bin\Release folder

```
nuget spec Obops.dll
rem then edit .nuspec file and renamed it to Obops.nuspec
nuget pack Obops.nuspec
nuget push ObObjs-0.0.1.nupkg
```

The used .nuspec file was copied to Src\Obops folder