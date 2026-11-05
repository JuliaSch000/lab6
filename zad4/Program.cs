using System.Diagnostics.CodeAnalysis;

// zad 4 od 80 linii

Console.WriteLine("Podaj imię");
string heroName = Console.ReadLine()!;
int health = 70;
int maxHealth = 100;
int gold = 15;
int strength = 6;
int weaponDamage = 3;
bool isRunning = true;

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


int CalculateDamage(int strength, int weaponDamage)
{
    int damage = strength + weaponDamage;
    return damage;
}
int Heal(int health, int amount, int maxHealth)
{
     if (amount <= 0)
    {
        return health;
    }

    int newHealth = health + amount;
    return Math.Min(newHealth, maxHealth);
}
bool IsGameOver(int health)
{
    return health <= 0;
}

void GameOverChecker()
{
    if (IsGameOver(health))
                {
                    Console.WriteLine("Game over");
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("Żyjesz :)");
                }
}

//Czesc zajmujaca sie zad 4


string ReadCommand()
{
    while (true)
    {
        Console.Write("Wybór: ");
        string? command = Console.ReadLine();
        if (command == "1" || command == "2" || command == "3")
        {
            return command;
        }

         Console.WriteLine("Nieznana komenda.");

    }
}







//

while (isRunning)
{
    ShowPanelTitle(title, ConsoleColor.Green);
    ShowStatus(heroName, health, maxHealth, gold);
    ShowMenu();
    Console.WriteLine("Wybierz 1-3");
    string wybor = ReadCommand();
    switch (wybor)
    {
        case "1":
            {
                
                Console.WriteLine($"Atakujesz potwora i zadajesz {CalculateDamage(strength, weaponDamage)} obrażeń.");
                Pause();
                Console.WriteLine("Z jakiegoś powodu leczysz HP o 20 punktów");
                Console.WriteLine($"Masz teraz {Heal(health, 20, maxHealth)}/{maxHealth} HP");
                GameOverChecker();
                Pause();
                Console.WriteLine("A teraz leczycsz HP o 30 punktów");
                Console.WriteLine($"Masz teraz {Heal(health, 30, maxHealth)}/{maxHealth} HP");
                GameOverChecker();
                Pause();
                Console.WriteLine("Ale teraz umierasz");
                health = 0;
                GameOverChecker();
                
                break;
            }
        default:
            {
                break;
            }
    }
    Pause();
    
}

Console.WriteLine("Koniec programu");