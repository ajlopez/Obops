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

