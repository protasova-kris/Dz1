// 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

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
//Печатаем двумерный массив
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
//Выводим результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}
//Нахождение строки с наименьшей суммой элементов
int FindMinRow(int[,] array)
{
    int outIndexRow = 1;
    int min = int.MaxValue;
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (min > sum)
        {
            min = sum;
            outIndexRow = i;
        }
        sum = 0;
    }
    return outIndexRow + 1;
}


int[,] arr2D = Fill2DArray(5, 4, 0, 9);
Print2DArray(arr2D);
PrintResult("Индекс строки с наименьшей суммой элементов: " + FindMinRow(arr2D));