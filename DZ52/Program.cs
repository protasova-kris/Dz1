//  52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Метод, печатает одномерный массив
void Print1DArrayDouble(double[] arr)
{
    string arrString = String.Empty;

    for (int i = 0; i < arr.Length - 1; i++)
    {
        arrString += arr[i] + "; ";
    }

    arrString += arr[arr.Length - 1];
    Console.WriteLine(arrString);
}

//Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Метод генерации и заполнения массива
int[,] Fill2DArray(int rows, int cols, int numMin, int numMax)
{
    // Создаём массив
    int[,] array2D = new int[rows, cols];

    if (numMin < numMax)
    {
        // Заполняем массив
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array2D[i, j] = new Random().Next(numMin, numMax+1);
            }
        }
    }

    return array2D;
}

// Метод, принимает [,] массив, возвращает [] массив средних арифметических значений столбцов.
double[] ArithmeticMean(int[,] arr2D)
{
    // Создаём новый одномерный массив
    double[] colArithmetic = new double[arr2D.GetLength(1)];

    // В циклах заполняем массив, прибавляя значения по столбцам
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            colArithmetic[j] += arr2D[i, j];
        }
    }

    return DivideArr(colArithmetic, arr2D.GetLength(0));
}

// Метод, делящий элементы массива на заданный делитель
double[] DivideArr(double[] arr, int divider)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(arr[i] / divider, 2);
    }

    return arr;
}

// Данные для генерации массива
int numMin = 10;
int numMax = 99;

int inputRows = ReadData("Введите количество строк: ");
int inputCols = ReadData("Введите количество столбцов: ");
int[,] array2D = Fill2DArray(inputRows, inputCols, numMin, numMax);

Print2DArray(array2D);
Console.WriteLine();
PrintResult("Cреднее арифметическое для столбцов: ");
Print1DArrayDouble(ArithmeticMean(array2D));