// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int[,] NewMatrix(int rows, int colums, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, colums];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}


//Выводит в консоль матрицу
void PrintMatrix(int[,] matrix)
{
    int count = 1;
    int length = 5;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (count <= Math.Abs(matrix[i, j]))
            {
                count *= 10;
                length++;
            }
        }
    }

    Console.Clear();

    int leftPosition;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            leftPosition = j * (length + 1);
            if (matrix[i, j] >= 0) leftPosition++;
            Console.SetCursorPosition(leftPosition, i);
            Console.Write($"{matrix[i, j]} ");
        }
    }
}

void ValueOutput(int[,] matrix)
{
    Console.Write("Введите порядковый номер строки: ");
    int rows = int.Parse(Console.ReadLine()!);

    Console.Write("Введите порядковый номер столбца: ");
    int colums = int.Parse(Console.ReadLine()!);

    if (rows <= matrix.GetLength(0) & colums <= matrix.GetLength(1) & rows > 0 & colums > 0)
    {
        Console.WriteLine($"Значение: {matrix[rows - 1, colums - 1]}");
    }
    else Console.WriteLine("Такого значения нет в данном массиве");
}


int[,] matrix = NewMatrix(10, 10, -100, 100);
PrintMatrix(matrix);
Console.WriteLine();
ValueOutput(matrix);

