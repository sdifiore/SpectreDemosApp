using Spectre.Console;
using SpectreDemos;

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
//List<string> names = ["Catia", "Manu", "Marisa", "Ana", "Luciana"];
//string name = AnsiConsole.Prompt(
//	new SelectionPrompt<string>()
//		.Title("Select your [green]name[/]?")
//		.PageSize(4)
//		.MoreChoicesText("[grey](Move up and down to reveal more names)[/]")
//		.AddChoices(names));

//AnsiConsole.MarkupLine($"You selected [yellow]{name}[/]");

// Lesson 6 - Multi-Select Lists with Groupings
//List<string> usualNames = ["Catia", "Manu", "Marisa", "Ana", "Luciana"];
//List<string> familyNames = ["Castelvetrano", "Ibi", "Santos", "Claudia", "Barone"];

//List<string> favoriteName = AnsiConsole.Prompt(
//	new MultiSelectionPrompt<string>()
//		.Title("Select your [green]name[/]?")
//		.InstructionsText(
//			"[grey](Press [blue]<space>[/] to toggle a name, " +
//			"[green]<enter>[/] to accept)[/]")
//		// AddChoices(usualNames) // without groups
//		.AddChoiceGroup("Usual Names", usualNames) // using only one group allows to select all items in the group with a single click
//		.AddChoiceGroup("Family Names", familyNames)
//);

//foreach (var name in favoriteName)
//{
//	Console.WriteLine(name);
//}

// Lesson 7 - Tables
//List<Text> person = [new Text("Catia", new Style(foreground: Color.Red, decoration: Decoration.Bold)),
//	new Text("Manu", new Style(foreground: Color.Green, decoration: Decoration.Bold)),
//	new Text("Marisa", new Style(foreground: Color.Blue, decoration: Decoration.Bold))];

//var table = new Table();
//table.Centered(); // Center the table in the console, not the text in the cells
//				  //table.Expand();   // Make the table take the full width of the console
//table.Border(TableBorder.Rounded);
//table.ShowRowSeparators();

//table.AddColumn("First Name");
//table.AddColumn("Last Name");
//table.AddColumn("Age");

//table.Columns[0].PadLeft(5).PadRight(5);
//table.Columns[1].Width(15).RightAligned();

//table.AddRow("Catia", "Castelvetrano", "30");
//table.AddRow("Manu", "Ibi", "28");
//table.AddRow("Marisa", "Santos", "25");
//table.AddRow(person);

//AnsiConsole.Write(table);

// Lesson 8 - Panels

//List<string> names = ["Catia", "Manu", "[red]Marisa[/]", "Ana", "Luciana"];

//var panelInfo = string.Join(Environment.NewLine, names);

//var panel = new Panel(new Markup(panelInfo).Centered());

//panel.Header = new PanelHeader("Panel Header", Justify.Center);

//panel.Border = BoxBorder.Rounded;
//panel.Padding = new Padding(2, 1);

//AnsiConsole.Write(panel);

// Lesson 9 - FIGlet Text
//AnsiConsole.Write(new FigletText("Hello")
//		.Centered()
//		.Color(Color.Green));

//var figlet = new FigletText("World");
//figlet.Centered();
//figlet.Color(Color.Green);
//AnsiConsole.Write(figlet);


//Console.ReadLine();
//AnsiConsole.Clear();

// Lesson 10 - Displaying JSON

//var jsonResponse = await Helpers.FetchApiDataAsync("https://api.restful-api.dev/objects");

//JsonText json = new(jsonResponse);

//json.StringColor(Color.Yellow);
//json.ColonColor(Color.Orange1);

//AnsiConsole.Write(
//	new Panel(json)
//	.Header("API Response")
//	.Collapse()
//	.BorderColor(Color.White)
//	);

// Lesson 11 - Status Messages
//await AnsiConsole.Status()
//	.StartAsync("Processing...", async ctx => // Not thread safe, use Start instead of StartAsync
//	{
//		ctx.Spinner(Spinner.Known.Aesthetic);

//		for (int i = 1; i < 21; i++)
//		{
//			ctx.Status($"Processing item {i}/20");

//			var jsonResponse = await Helpers.FetchApiDataAsync(
//	$"https://thesampleapi.com/courses/{i}");

//			AnsiConsole.MarkupLine($"[green]Fetched {i}[/] data item");
//		}
//	});

// Lesson 12 - Progress Bars
//await AnsiConsole.Progress()
//	.AutoClear(true) // default is true, set to false to keep the progress bar after completion
//	.StartAsync(async ctx =>
//	{
//		var task1 = ctx.AddTask("[green]Downloading Data[/]");
//		var task2 = ctx.AddTask("[green]Installing Application[/]");
//		var task3 = ctx.AddTask("[green]Data Cleanup[/]");

//		while (!ctx.IsFinished)
//		{
//			await Task.Delay(500);

//			task1.Increment(Random.Shared.NextDouble() * 25);
//			task2.Increment(Random.Shared.NextDouble() * 18);

//			if (task2.Percentage > 80)
//				task3.Increment(Random.Shared.NextDouble() * 20);
//		}
//	});

// Lesson 13 - Live Displays
List<CourseInfo> courses = [];

var table = new Table().Centered();

table.AddColumn("Title");
table.AddColumn("Lessons");
table.AddColumn("Hours");
table.ShowFooters();

await AnsiConsole.Live(table)
	.StartAsync(async ctx =>
	{
		for (int i = 1; i < 32; i++)
		{
			var course = await Helpers.GetTypedApiDataAsync<CourseInfo>(
			$"https://thesampleapi.com/courses/{i}");
			courses.Add(course);

			table.AddRow(
				course.CourseName,
				course.CourseLessonCount.ToString(),
				course.CourseLengthInHours.ToString());

			table.Columns[0].Footer($"[grey]{courses.Count} courses[/]");
			table.Columns[1].Footer($"[grey]{courses.Sum(c => c.CourseLessonCount).ToString()}[/]");
			table.Columns[2].Footer($"[grey]{courses.Sum(c => c.CourseLengthInHours):0.0} hours[/]");

			ctx.Refresh();
			await Task.Delay(100);
		}

	});

Console.ReadLine();
AnsiConsole.Clear();
