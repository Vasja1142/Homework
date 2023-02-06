//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

Console.Write("Введите координату первой точки по оси X: ");
int X1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату первой точки по оси Y: ");
int Y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату первой точки по оси Z: ");
int Z1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату второй точки по оси X: ");
int X2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату второй точки по оси Y: ");
int Y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату второй точки по оси Z: ");
int Z2 = int.Parse(Console.ReadLine()!);

int X = X1 - X2;
int Y = Y1 - Y2;
int Z = Z1 - Z2;
double result = Math.Sqrt(X * X + Y * Y + Z * Z);

Console.Write($"Расстояние между двумя точками: {result:f2}");
