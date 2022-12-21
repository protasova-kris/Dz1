﻿// 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}
//Метод подсчета любой степени чисел от 1 до N
string LineNums(int numberN, int pow)
{
    int i = 1;

    string outLine = string.Empty;
    while (i < numberN)
    {
        outLine = outLine + Math.Pow(i, pow) + "\t";
        ++i;
    }
    outLine = outLine + Math.Pow(numberN, pow);
    return outLine;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}


int num = ReadData("Введите число N: ");

PrintResult(LineNums(num, 1));
Console.WriteLine();
PrintResult(LineNums(num, 3));