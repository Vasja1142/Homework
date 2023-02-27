// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ack(int M, int N, int result = 0)
{
    if (N == 0)return result = M + 1;
    else if (M == 0) return Ack(M + 1, N - 1, result);
    else return Ack(Ack(M - 1, N, result), N - 1, result);
}

Console.Clear();
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

int result = Ack(N, M);
Console.WriteLine($"A({M}, {N}) = {result}");
