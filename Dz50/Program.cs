// 50. Напишите программу, которая на вход принимает число, и возвращает индексы числа в двумерном массиве или же указание, 
// что такого элемента нет.

// Считывание данных с консоли.
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Универсальный метода генерации и заполнения двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int downBorder, int topBorder)
{   //Генератор случайных чисел
    System.Random rnd = new System.Random();
    //Создаем массив
    int[,] array2D = new int[countRow, countColumn];
    //Тест границ
    if (downBorder < topBorder)
    { //Заполнение массива
        for (int i = 0; i < countRow; i++)
        {
            for (int j = 0; j < countColumn; j++)
            {
                array2D[i, j] = rnd.Next(downBorder, topBorder + 1);
            }
        }
    }
    return array2D;
}

// Печатаем двумерный массив
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Нахождение элемента по индексу
int FindElement(int row, int column, int[,] array2D)
{
    if ((row < array2D.GetLength(0)) && (column < array2D.GetLength(1)))
    {
        return array2D[row, column];
    }
    else
    {
        return -1;
    }
}

// Вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int[,] arr2D = Fill2DArray(7, 8, 10, 99);
Print2DArray(arr2D);
Console.WriteLine();
int rowNum = ReadData("Введите номер строки: ") - 1;
int columnNum = ReadData("Введите номер столбца: ") - 1;

PrintResult((FindElement(rowNum, columnNum, arr2D) == -1) ? "Элемента в массиве нет"
: ("Искомый элемент: " + FindElement(rowNum, columnNum, arr2D)));