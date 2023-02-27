// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumOfNumbers(int M, int N, int result = 0)
{
    if (N < M)return result;
    else 
    {
    return SumOfNumbers(M + 1, N, result += M);
    }
}

Console.Clear();
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);


int result = SumOfNumbers(M, N);
Console.WriteLine($"Cумма натуральных элементов в промежутке от {M} до {N}: {result}");
