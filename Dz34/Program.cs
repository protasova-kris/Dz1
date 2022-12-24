// 34. Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] FillArray(int arrLength, int downBorder, int topBorder)
{
    //Генератор случайных чисел
    Random numSintezator = new Random();
    //Создаем массив
    int[] arr = new int[arrLength];
    //Тест границ
    if (downBorder < topBorder)
    {
        //Заполняем массив
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = numSintezator.Next(downBorder, topBorder + 1);
        }
    }
    //Возвращаем результат
    return arr;
}


int CounterEven(int[] arr)
{
    int countEv = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) countEv++;
    }
    return countEv;
}

// Метод сортировки пузырьком.
int[] BubbleSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - i; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                int temp;
                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
    return arr;
}

void Print1DArray(int[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

void PrintCountEven(int line)
{
    Console.WriteLine(line);
}

int[] array = FillArray(12, 100, 1000);
Print1DArray(array);
PrintCountEven(CounterEven(array));
Print1DArray(BubbleSort(array));