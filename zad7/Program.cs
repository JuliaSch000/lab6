// A

// "health" nie istnieje dla siodmej linijki. Trzeba je gdzieś zdefiniować
int health = 20;
// i to "health" bedzie roznilo sie od tego w szostej linijce
int Heal(int health, int amount) => health + amount;
Heal(health, 10);
// "Heal" sie samo nie wyswietla
Console.WriteLine(Heal(health, 10));

// B


// "warning" nie istnieje poza if-em
if (health < 30)
{
    string warning = "Mało zdrowia!";
}

// zrobie z tego to 

void Warning(int health)
{
    if (health < 30)
    {
    Console.WriteLine("\nMało zdrowia!\n");
    }
}

Warning(health);

// C


int CalculateDamageOLD(int strength, int weaponDamage)
{
    Console.Write("Czy chcesz zaatakować? ");
    string? answer = Console.ReadLine();
    Console.WriteLine("Rozpoczynam animację ataku...");
    return strength + weaponDamage;
}

// Widze ze ta metoda jest int-em, ale niepotrzebnie wykonuje inne czynnosci. 

// po wykonaniu CalculateDamage(n, n) nie dostajemy returna

void AttackPrompt()
{
    //usune ten prompt do ataku zeby szybciej testowac
    Console.WriteLine("Rozpoczynam animację ataku...");
    
}

int CalculateDamage(int strength, int weaponDamage) => strength + weaponDamage;

AttackPrompt();
Console.WriteLine($"Zadałeś {CalculateDamage(5, 6)} obrażeń!\n");

// D

bool CanHeal(int health, int maxHealth, int potions) => 
    (health < maxHealth) && (potions > 0) && (health > 0);
    // bez nawiasow tez dzialalo

Console.WriteLine(CanHeal(30, 100, 4)); //true
Console.WriteLine(CanHeal(0, 100, 4)); //false
Console.WriteLine(CanHeal(100, 100, 4)); //false
Console.WriteLine(CanHeal(30, 100, 0)); //false

bool CanHealTwo(int health, int maxHealth, int potions)
{
    return (health < maxHealth) && (potions > 0) && (health > 0);
}
    
Console.WriteLine("");
Console.WriteLine(CanHealTwo(30, 100, 4)); //true
Console.WriteLine(CanHealTwo(0, 100, 4)); //false
Console.WriteLine(CanHealTwo(100, 100, 4)); //false
Console.WriteLine(CanHealTwo(30, 100, 0)); //false


// Wszystko dziala w obydwu metodach. wybieram zapis strzalkowy bo jest bardziej intuicyjny