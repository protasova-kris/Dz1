// 1. По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Укажите первое число ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Укажите второе число ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Узнаем является ли первое число квадратом второго");
if (b*b==a){
    Console.WriteLine("Первое число является квадратом второго.");
}
else {
    Console.WriteLine("Первое число не является квадратом второго.");
}