using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("ColorConsole")]
[assembly: AssemblyProduct("Console Utilities")]
[assembly: AssemblyDescription(@"Outputs a line to console, coloring the console according to color codes in double-curly brackets.

Example 1: ""{{green}}Testing a {{default}}\""Hello world\""{{cyan}} string!"" {{red}}Amazing!
Example 2: Backup {{green}}succeeded{{default}}!
Example 3: Backup {{red}}failed{{default}}!

Allowed color codes defined here:
https://msdn.microsoft.com/en-us/library/system.consolecolor(v=vs.110).aspx

Special code for resetting color:
{{default}}")]
[assembly: AssemblyCompany("gehtnicht.at")]
[assembly: AssemblyCopyright("Copyright © gehtnicht.at 2015")]
[assembly: Guid("894fdcec-01f4-4350-8fbf-9e4cc31b99da")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyInformationalVersion("1.0.0")]
