// 38.Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] GenArr(int arrLen, int minValue, int maxValue)
{
    double[] arr = new double[arrLen];
    Random rnd = new Random();

    for (int i = 0; i < arrLen; i++)
    {
        arr[i] = rnd.NextDouble() * 100 - 10;
    }
    return arr;
}
//Вычисление разницы значений.
double MaxMinDifference(double[] arr)
{
    double max = int.MinValue;
    double min = int.MaxValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return (max - min);
}
//Вывод массива.
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{Math.Round(array[i], 2)}\t");
    }
    
}
//Вывод результата.
void PrintResult(string line)
{
    Console.WriteLine(line);
}

double[] range = GenArr(15, 10, 100);
PrintArray(range);
PrintResult("Разница между максимальным и мнимальным элементом массива равна: " 
+ MaxMinDifference(range));