// 25.Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)

//2, 4 -> 16



Console.WriteLine("Введите число А и число В");
int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);
int index = 1;
int result = 1;
while (index <= B)
{
    result = result * A;
    index = index + 1;
}
Console.WriteLine(result);
