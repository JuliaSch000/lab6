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
    Console.WriteLine("Mało zdrowia!");
    }
}

Warning(health);