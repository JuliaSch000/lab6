using System.Diagnostics.CodeAnalysis;



Console.WriteLine("Podaj imię");
string heroName = Console.ReadLine()!;
int health = 70;
int maxHealth = 100;
int gold = 15;
int strength = 6;
int weaponDamage = 3;
bool isRunning = true;


// wybor 2 to sprawdza
List<string> inventory = new List<string> { "miecz", "mikstura", "łuk" };

List<string> longNames = inventory.FindAll(item => item.Length > 5);
bool hasPotion = inventory.Exists(item => item == "mikstura");



string title = "HELLO ADVENTURER";

// uzasadnienie : Nie jest jedną linijką
void ShowStatus(string name, int health, int maxHealth, int gold)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("+===============+");
    Console.WriteLine($"Imię: {name}");
    Console.WriteLine($"HP: {health}/{maxHealth}");
    Console.WriteLine($"Złoto: {gold}");
    Console.ResetColor();
}
// -,,-
void ShowMenu()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("1 - WALCZ");
    Console.WriteLine("2 - EKWIPUNEK");
    Console.WriteLine("3 - WYJDŹ Z GRY");
    Console.ResetColor();
}
// -,,-
void ShowPanelTitle(string title, ConsoleColor backgroundColor)
{
    Console.BackgroundColor = backgroundColor;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"  {title.ToUpper()}  ");
    Console.ResetColor();
}

//To moja oryginalna funkcja (TM). Nie umiem jej zmienic i to moje uzasadnienie
void Pause()
{
    string pausing = Console.ReadLine();
}

//tutaj byla jedna linijka
int CalculateDamage(int strength, int weaponDamage) => strength + weaponDamage;

//tutaj nie
int Heal(int health, int amount, int maxHealth)
{
     if (amount <= 0)
    {
        return health;
    }

    int newHealth = health + amount;
    return Math.Min(newHealth, maxHealth);
}

// tutaj jedna linijka
bool IsGameOver(int health) => health <= 0;

// ta funkcja tez ma wiecej niz jedna linjke
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



// ta tez
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
        case "2":
            {
                Console.WriteLine("\nEkwipunek:\n");
                foreach (string item in inventory)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine($"\nDługie nazwy:\n");
                foreach (string item in longNames)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine($"\nMikstura: {hasPotion}\n");
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