// 4. Выяснить является ли число чётным
Console.Write("Введите число: ");
string? inputline = Console.ReadLine();

//проверка на пустое значение
if (inputline != null)
{
    int inputNumber = int.Parse(inputline);// присваиваем вещественное значение
    int outResult = inputNumber % 2;// проверяем остаток от деления на 2
    if (outResult == 0)
    {
       Console.WriteLine("Итог: Четное") ;// выводим если остатка нет
    }
    else
    {
        Console.WriteLine("Итог: Нечетное");// выводим если остаток есть
    }
}