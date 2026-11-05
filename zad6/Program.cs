using System.Diagnostics.CodeAnalysis;



Console.WriteLine("Podaj imię");
string heroName = Console.ReadLine()!;
int health = 70;
int maxHealth = 100;
int gold = 15;
int strength = 6;
int weaponDamage = 3;
bool isRunning = true;



List<string> inventory = new List<string> { "miecz", "mikstura", "łuk" };

List<string> longNames = inventory.FindAll(item => item.Length > 5);
bool hasPotion = inventory.Exists(item => item == "mikstura");

List<string> historia = new List<string>();

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
    Console.WriteLine("2 - EKWIPUNEK");
    Console.WriteLine("3 - POKAŻ HISTORIĘ");
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


int CalculateDamage(int strength, int weaponDamage) => strength + weaponDamage;


int Heal(int health, int amount, int maxHealth)
{
     if (amount <= 0)
    {
        return health;
    }

    int newHealth = health + amount;
    return Math.Min(newHealth, maxHealth);
}


bool IsGameOver(int health) => health <= 0;


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
    

    if (wybor == "1")
            {
                
                Console.WriteLine($"Atakujesz potwora i zadajesz {CalculateDamage(strength, weaponDamage)} obrażeń.");
                Pause();
                Console.WriteLine("Z jakiegoś powodu leczysz HP o 20 punktów");
                Console.WriteLine($"Masz teraz {Heal(health, 20, maxHealth)}/{maxHealth} HP");
                GameOverChecker();
                Pause();
                
                historia.Add("--Walka--");
                
                continue;
            }
    else if (wybor == "2")
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
                historia.Add("--Sprawdzenie ekwipunku--");
                Pause();
                continue;
            }
    else if (wybor == "3")
      {
        foreach (string item in historia)
                {
                    Console.WriteLine(item);
                }
        Pause();

        continue;
      }
    else
    {
        isRunning = false;
        break;

    }
    
    
}

Console.WriteLine("Koniec programu");