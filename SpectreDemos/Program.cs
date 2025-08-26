using Spectre.Console;














// Lesson 2 - Initial setup
//AnsiConsole.MarkupLine("[red bold]Hello World[/]");
//AnsiConsole.MarkupLine("Hello World");
//AnsiConsole.MarkupLine("[slowblink]Hello World[/]");

// Lesson 3 - Color and Style
AnsiConsole.MarkupLine("[red on white bold]Hello[/] [green]World[/]");

Style danger = new Style(
	foreground: Color.Red,
	background: Color.White,
	decoration: Decoration.Bold | Decoration.Italic);

AnsiConsole.Write(new Markup("Danger Text from Style\n", danger));


AnsiConsole.Write(new Markup("Danger Text from Style again, no lf", danger));
AnsiConsole.WriteLine(" and more text on the same line");

Console.ReadLine();
AnsiConsole.Clear();
