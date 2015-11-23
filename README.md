# Color Console

Outputs a line to console, coloring the console according to color codes in double-curly brackets.

- Allowed color codes defined here: <a href="https://msdn.microsoft.com/en-us/library/system.consolecolor(v=vs.110).aspx">MSDN ConsoleColor Enumeration</a>
- Special code for resetting color: `{{default}}`

## Example 1
`"{{green}}Testing a {{default}}\"Hello world\"{{cyan}} string!" {{red}}Amazing!`

Output: <span style="color: green">Testing a</span> "Hello world" <span style="color: cyan">string!</span> <span style="color: red;">Amazing!</span>

## Example 2
`Backup {{green}}succeeded{{default}}!`

Output: Backup <span style="color: green;">succeeded</span>!

## Example 3
`Backup {{red}}failed{{default}}!`

Output: Backup <span style="color: red;">failed</span>!
