using System.Diagnostics.CodeAnalysis;

string heroName = Console.ReadLine()!;
int health = 70;
int maxHealth = 100;
int gold = 15;
string title = "HELLO ADVENTURER";

void ShowStatus(string name, int health, int maxHealth, int gold)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("+===============+");
    Console.WriteLine($"Imię: {name}");
    Console.WriteLine($"HP: {health}/{maxHealth}");
    Console.WriteLine($"Złoto: {gold}");
    Console.ResetColor();
}
void ShowMenu()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("1 - WALCZ");
    Console.WriteLine("2 - ODPOCZNIJ");
    Console.WriteLine("3 - WYJDŹ Z GRY");
    Console.ResetColor();
}
void ShowPanelTitle(string title, ConsoleColor backgroundColor)
{
    Console.BackgroundColor = backgroundColor;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"  {title.ToUpper()}  ");
    Console.ResetColor();
}

void Pause()
{
    string pausing = Console.ReadLine();
}

bool isRunning = true;

while (isRunning)
{
    ShowPanelTitle(title, ConsoleColor.Green);
    ShowStatus(heroName, health, maxHealth, gold);
    ShowMenu();
    Pause();
    
}