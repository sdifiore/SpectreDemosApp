using Spectre.Console;









// Lesson 2 - Initial setup
//AnsiConsole.MarkupLine("[red bold]Hello World[/]");
//AnsiConsole.MarkupLine("Hello World");
//AnsiConsole.MarkupLine("[slowblink]Hello World[/]");

// Lesson 3 - Color and Style
//AnsiConsole.MarkupLine("[red on white bold]Hello[/] [green]World[/]");

//Style danger = new Style(
//	foreground: Color.Red,
//	background: Color.White,
//	decoration: Decoration.Bold | Decoration.Italic);

//AnsiConsole.Write(new Markup("Danger Text from Style\n", danger));


//AnsiConsole.Write(new Markup("Danger Text from Style again, no lf", danger));
//AnsiConsole.WriteLine(" and more text on the same line");

// Lesson 4 -  Text Prompts
//int age = AnsiConsole.Ask<int>("What is your [green]age[/]?");
//int age = AnsiConsole.Prompt(
//	new TextPrompt<int>("What is your [green]age[/]?")
//		.Validate(age =>
//		{
//			return age switch
//			{
//				< 0 => ValidationResult.Error("[red]Age cannot be negative[/]"),
//				> 120 => ValidationResult.Error("[red]Age cannot be greater than 120[/]"),
//				_ => ValidationResult.Success(),
//			};
//		})
//		.DefaultValue(25)
//		.PromptStyle("green")
//);

//bool isHappy = AnsiConsole.Confirm("Are you [green]happy[/]?");

//string happyText = AnsiConsole.Prompt(
//	new TextPrompt<string>("Are you happy?")
//		.AddChoice("Yes")
//		.AddChoice("No")
//		.DefaultValue("Yes")
//		.PromptStyle("green")
//);

//string happyText = AnsiConsole.Prompt(
//	new SelectionPrompt<string>()
//		.Title("Are you [green]happy[/]?")
//		.AddChoices(new[] { "Yes", "No" }));

//AnsiConsole.MarkupLine($"You are [yellow]{age}[/] years old and it is [yellow]{happyText}[/] that you are happy.");

// Lesson 5 -  Item Selections
List<string> names = ["Catia", "Manu", "Marisa", "Ana", "Luciana"];
string name = AnsiConsole.Prompt(
	new SelectionPrompt<string>()
		.Title("Select your [green]name[/]?")
		.PageSize(4)
		.MoreChoicesText("[grey](Move up and down to reveal more names)[/]")
		.AddChoices(names));

AnsiConsole.MarkupLine($"You selected [yellow]{name}[/]");

Console.ReadLine();
AnsiConsole.Clear();
