// 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Чтение данных из консоли.
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

// Метод вывода данных.
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//Метод вывода чисел от M до N.
string RecMN(int numM, int numN)
{
    //Точка остановки
    if (numM >= numN) return numN.ToString();
    string outLine = numM + " " + RecMN(numM + 1, numN);
    return outLine;
}

int M = ReadData("Введите число М: ");
int N = ReadData("Введите число N: ");
string numbers = string.Empty;
numbers = (M < N) ? RecMN(M, N) : RecMN(N, M);
PrintResult(numbers);