// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int[] SortingElements(int[] array)
{
    int min;
    int indexMin;
    for (int i = 0; i < array.Length; i++)
    {
        min = array[i];
        indexMin = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (min > array[j])
            {
                min = array[j];
                indexMin = j;
            }
        }
        if (i != indexMin)
        {
            array[i] += min;
            array[indexMin] = array[i] - array[indexMin];
            array[i] -= array[indexMin];
        }
    }
    return array;
}

Console.Clear();
int[] array = GetArray(10, 1, 100);
Console.WriteLine($"Массив: [{String.Join(", ", array)}]");
array = SortingElements(array);
Console.WriteLine($"Сортированный массив: [{String.Join(", ", array)}]");
