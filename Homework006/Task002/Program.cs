// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Даны 2 уравнения:");
Console.WriteLine("y = k1 * x + b1");
Console.WriteLine("y = k2 * x + b2");

Console.Write("Введите переменную k1: ");
double k1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите переменную b1: ");
double b1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите переменную k2: ");
double k2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите переменную b2: ");
double b2 = int.Parse(Console.ReadLine()!);

double x;
double y;

// k1 * x + b1 = k2 * x + b2
// x * k1 = k2 * x + b2 - b1
// x * k1 - (k2 * x) = b2 - b1
// x * (k1 - k2) = b2 - b1
x = (b2 - b1) / (k1 - k2);
y = k1 * x + b1;

Console.WriteLine($"x = {x}");
Console.WriteLine($"y = {y}");
