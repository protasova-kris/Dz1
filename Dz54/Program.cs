// 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

//Универсальный метода генерации и заполнения двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int downBorder, int topBorder)
{
    System.Random numSintezator = new System.Random();
    //Создаем массив
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = numSintezator.Next(downBorder, topBorder + 1);
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

// Сортируем элементы каждой строки по убыванию
int[,] SortMaxMinArray(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        List<int> row = new List<int>();
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            row.Add(arr2D[i, j]);
            row.Sort();
        }
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            arr2D[i, j] = row[arr2D.GetLength(1) - j - 1];
        }
    }
    return arr2D;
}

int[,] arr2D = Fill2DArray(5, 5, 0, 9);
Print2DArray(arr2D);
Console.WriteLine("Сортированный массив: ");
Print2DArray(SortMaxMinArray(arr2D));