void ShowMessage(string text)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    Console.ResetColor();
}

ShowMessage("Aaaaah");

int AddGold(int gold, int reward)
{
    return gold + reward;
}

Console.WriteLine(AddGold(3, 4));


bool HasEnoughGold(int gold, int price) => gold >= price;

Console.WriteLine(HasEnoughGold(3, 4));