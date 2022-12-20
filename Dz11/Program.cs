// 11. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();
//проверка на пустое значение
if (inputLine != null)
{   //проверка длины массива
    if (inputLine.Length >= 3)
    {   //Преобразование строки в массив
        char[] charArray = inputLine.ToString().ToCharArray();
        //вывод данных
        Console.WriteLine(charArray[2]);
    }
    else
    {   //вывод в случае не соответствия длине массива
        Console.Write("число слишком короткое");
    }
}