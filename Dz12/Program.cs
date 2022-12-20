// 12.Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.


//Считываем данные
Console.Write("Введите число: ");
string? inputLine = Console.ReadLine() ?? "";
// присваиваем вещественное значение
int inputNumber = int.Parse(inputLine);
if (inputNumber > 7 || inputNumber < 1)
{
    Console.WriteLine("Неделя - 7 дней, следовательно: такого дня нет");
}
else
{
    if (inputNumber == 6 || inputNumber == 7)
    {
        //вывод данных
        Console.WriteLine("Выходной день");
    }
    else
    {
        //вывод при невыполнении условия 
        Console.WriteLine("Будний день");
    }
}