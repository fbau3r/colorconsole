using System;
using System.Linq;
using System.Reflection;

namespace ColorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(Assembly.GetExecutingAssembly().GetCustomAttributes<AssemblyDescriptionAttribute>().First().Description);
                Console.ResetColor();
                return;
            }

            // example for program arguments: "{{Green}}Testing a {{Default}}\"Hello world\"{{Cyan}} string!" {{Red}}Amazing!
            var message = string.Join(" ", args);
            var elements = message.Split(new[] {"{{"}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var element in elements)
            {
                if (!element.Contains("}}"))
                {
                    Console.Write(element);
                    continue;
                }

                var splitElement = element.Split(new[] { "}}" }, 2, StringSplitOptions.None);

                var colorText = splitElement[0];
                if ("default".Equals(colorText, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.ResetColor();
                }
                else
                {
                    ConsoleColor color;
                    if (!Enum.TryParse(colorText, true, out color))
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Error.WriteLine("ERROR: Invalid Color: '{0}'. Expected a valid ConsoleColor like '{1}'", colorText, string.Join("' or '", Enum.GetNames(typeof(ConsoleColor))));
                        Console.ResetColor();
                        break;
                    }

                    Console.ForegroundColor = color;
                }

                Console.Write(splitElement[1]);
            }

            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
