// 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int n = int.Parse(Console.ReadLine());

Console.WriteLine(PrintNumbers(n, 1));

string PrintNumbers(int start, int end)
{
    if (start == end) return end.ToString();
    return (start + " " + PrintNumbers(start - 1, end));
}