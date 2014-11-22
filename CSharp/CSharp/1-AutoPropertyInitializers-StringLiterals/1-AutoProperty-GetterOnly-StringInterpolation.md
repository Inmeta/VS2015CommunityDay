
Auto-property initializers

Getter-only auto-properties

[Assignment to readonly autoprops in ctors](https://roslyn.codeplex.com/discussions/568824)

[String interpolation](https://roslyn.codeplex.com/discussions/570292)


Current  syntax

    var s = "\{p.Name} is \{p.Age} year\{(p.Age == 1 ? "" : "s")} old";


Possible future syntax for string interpolation

    var s = $"{p.Name,20} is {p.Age:D3} year{{s}} old";