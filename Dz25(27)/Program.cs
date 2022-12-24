// 27/ Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

int SumDigit(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}

void PrintResult(string line)

{
    Console.WriteLine(line);
}

int number = ReadData("Введите число: ");
int sumOfDigits = SumDigit(number);
PrintResult("Сумма цифр в числе: " + sumOfDigits);