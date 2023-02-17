// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

void MaxMinValue(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"Максимальное значение массива: {max}");
    Console.WriteLine($"Минимальное значение массива: {min}");
}

int[] array = GetArray(20, 1, 1000);

Console.Clear();
Console.WriteLine($"Массив: [{String.Join(", ", array)}]");
MaxMinValue(array);