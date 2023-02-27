// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


int[] OutOfNumbers(int N, int[] array)
{
    if (N < 1)return array;
    else 
    {
    array[array.Length - N] = N;
    return OutOfNumbers(N - 1, array);
    }
}

Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

int[] array = new int[N];
int[] result = OutOfNumbers(N, array);
Console.WriteLine($"[{String.Join(", ", result)}]");