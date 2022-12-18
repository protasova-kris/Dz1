//  3. Найти максимальное из трех чисел


//считываем данные
Console.Write("Введите первое число: ");
string? firstLine = Console.ReadLine();
Console.Write("Введите второе число: ");
string? secondLine = Console.ReadLine();
Console.Write("Введите третье число: ");
string? thirdLine = Console.ReadLine();

//проверка на пустое значение

if (firstLine != null && secondLine != null && thirdLine != null)
{
    // присваиваем вещественное значение

    int firstNum = int.Parse(firstLine);
    int secondNum = int.Parse(secondLine);
    int thirdNum = int.Parse(thirdLine);
    //сравниваем числа и выводим результат
    if (firstNum > secondNum)
    {
        if (firstNum > thirdNum)
        {
            Console.WriteLine("Первое число максимальное");
        }
        else
        {
            Console.WriteLine("Третье число максимальное");
        }

    }
    else
    {
        if (secondNum > thirdNum)
        {
            Console.WriteLine("Второе число максимальное");
        }
        else
        {
            Console.WriteLine("Третье число максимальное");
        }

    }
}
