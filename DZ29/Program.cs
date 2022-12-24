// 29. Напишите программу, которая задаёт массив из 8 случайных чисел (-10, 10) и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{

    array[i] = new Random().Next(-10, 11);
    if (i == array.Length  -  1)
    {
        Console.Write(array[i] + ".");
    }
    else
    {
        Console.Write(array[i] + ", ");
    }
}