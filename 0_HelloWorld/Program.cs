//Change appearance of Console
Console.Title = "The World";
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WindowHeight = 40;

//Presentation
Console.WriteLine("Hello there traveller");
Console.WriteLine("What brings you here?");
Console.WriteLine("1. a drink 2. a bed for the night 3. just passing by");
int actions = Convert.ToInt32(Console.ReadLine());
if (actions == 3)
{
    Console.WriteLine("well good luck then traveller");
    return;
}
Console.WriteLine("Ah, that so?");
Console.WriteLine("well before i can give you that, you must do something for me");
Console.WriteLine("do you accept this quest?");
Console.WriteLine("yes or no?");

string userInput = Console.ReadLine();


if (userInput == "no")
{
    Console.WriteLine("sorry, then i cannot help you");
    return;
}
if (userInput == "yes")
{
    Console.WriteLine("ah splendid, i have a few things you could do for me");
}

Console.WriteLine("yeyeye");


Console.ReadKey();
