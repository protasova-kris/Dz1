// 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// x = (b2-b1)/(k1-k2);
// y = k1*x+b1;

//Тип double для учета отрицательных значений.
double ReadData(string line)
{
    Console.Write(line);
    //Считываем число и преобразуем из строки в double
    double number = double.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}
//Расчет координат пересечения прямых.
double[] PointFind(double k1, double b1, double k2, double b2)
{
    double[] outArr = new double[2];
    outArr[0] = (b1 - b2) / (k2 - k1);
    outArr[1] = outArr[0] * k1 + b1;
    return outArr;
}
//Печатаем одномерный массив.
void Print1DArray(string line, double[] array)
{
    Console.WriteLine(line);
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.WriteLine(array[array.Length - 1]);
}

double k1 = ReadData("Введите значение k1: ");
double b1 = ReadData("Введите значение b1: ");
double k2 = ReadData("Введите значение k2: ");
double b2 = ReadData("Введите значение b2: ");
Print1DArray("Координаты точки пересечения: ", PointFind(k1, b1, k2, b2));