// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] CreateArray()
{
    Console.Write("Введите длинну массива: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-e значение массива: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

int Counter(int[] array)
{
    int count = 0;
    foreach (int element in array)
    {
        if(element > 0) count++;
    }
    return count;
}

int[] array = CreateArray();
int result = Counter(array);

Console.Clear();
Console.WriteLine($"Массив: [{String.Join(", ", array)}]");
Console.WriteLine($"Чисел больше 0: {result}");
