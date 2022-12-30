// 60. Сформируйте трёхмерный массив из двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Универсальный метод генерации и заполнения трехмерного массива.
int[,,] Fill3DArray(int Row, int Column, int Depth)
{
    int[,,] array3D = new int[Row, Column, Depth];
    List<int> nums = Enumerable.Range(10, 90).ToList();
    //Генератор случайных чисел
    System.Random rnd = new System.Random();
    int index = 0;
    //Заполнение массива
    for (int i = 0; i < Row; i++)
    {
        for (int j = 0; j < Column; j++)
        {
            for (int k = 0; k < Depth; k++)
            {
                index = rnd.Next(nums.Count);
                array3D[i, j, k] = nums[index];
                nums.RemoveAt(index);
            }
        }
    }
    return array3D;

}

//Печатаем трехмерный массив.
void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}");
                Console.Write($"({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

Print3DArray(Fill3DArray(3, 3, 3));