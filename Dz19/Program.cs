// 19. Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом. (читается слева направо и справа налево одинаково)
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
string? number = Console.ReadLine();

void NumCheck(string namber )
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Число: {number} - палиндром.");
    }
    else Console.WriteLine($"Число: {number} - НЕ палиндром.");
}

if (number!.Length == 5)
{
    NumCheck(number);
}
else Console.WriteLine($"Введите пятизначное число");