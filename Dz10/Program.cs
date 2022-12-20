//10. Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.


//Считываем данные
Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();
//проверка на пустое значение
if (inputLine != null)
{   //проверка длины массива
    if (inputLine.Length == 3)
    {   //Преобразование строки в массив
        char[] charArray = inputLine.ToString().ToCharArray();
        //вывод данных
        Console.WriteLine(charArray[1]);
    }
    else
    {   //вывод в случае не соответствия длине массива
        Console.Write("число не трехзначное");
    }
}