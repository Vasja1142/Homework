// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetArray(int minValue, int maxValue)
{
    Console.Write("Введите длинну массива: ");
    int size = int.Parse(Console.ReadLine()!);

    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int[] array = GetArray(100, 999);
int finalResult = array.Length / 2;

Console.Clear();
Console.WriteLine($"Массив: [{String.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {finalResult}");