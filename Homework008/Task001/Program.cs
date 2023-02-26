// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Ввод характеристики матрицы через консоль
int[] MatrixDataInput()
{
    Console.Clear();

    Console.Write("Введите количество строк числовой матрицы: ");
    int rows = int.Parse(Console.ReadLine()!);

    Console.Write("Введите количество столбцов числовой матрицы: ");
    int columns = int.Parse(Console.ReadLine()!);

    Console.Write("Введите минимальное значение элемента матрицы: ");
    int minValue = int.Parse(Console.ReadLine()!);

    Console.Write("Введите максимальное значение элемента матрицы: ");
    int maxValue = int.Parse(Console.ReadLine()!);

    int[] data = { rows, columns, minValue, maxValue };

    return data;
}


//Создает числовую матрицу 
int[,] NewMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}


// Выводит в консоль матрицу
void PrintMatrix(int[,] matrix, int upPosition)
{
    int count = 1;
    int length = 1;
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
   
    int leftPosition;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            leftPosition = j * (length + 1);
            if (matrix[i, j] >= 0) leftPosition++;
            Console.SetCursorPosition(leftPosition, i + upPosition);
            Console.Write($"{matrix[i, j]} ");
        }
    }
}

int[,] MatrixSort(int[,] matrix)
{
    int minValue;
    int minСolumnIndex;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            minValue = matrix[i, j];
            minСolumnIndex = j;
            for (int k = j; k < matrix.GetLength(1); k++)
            {
                if (minValue > matrix[i, k])
                {
                    minValue = matrix[i, k];
                    minСolumnIndex = k;
                }
            }
            if (matrix[i, j] != matrix[i, minСolumnIndex])
            {
                matrix[i, j] += matrix[i, minСolumnIndex];
                matrix[i, minСolumnIndex] = matrix[i, j] - matrix[i, minСolumnIndex];
                matrix[i, j] -= matrix[i, minСolumnIndex];
            }
        }
    }
    return matrix;
}

// Вызов команд
int[] dataArray = MatrixDataInput();
int[,] matrix = NewMatrix(dataArray[0], dataArray[1], dataArray[2], dataArray[3]);
Console.Clear();
PrintMatrix(matrix, 0);
MatrixSort(matrix);
PrintMatrix(matrix, dataArray[0] + 1);