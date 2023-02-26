// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Ввод характеристики матрицы через консоль
int[] MatrixDataInput()
{
    Console.Clear();

    Console.Write("Введите количество строк числовой матрицы: ");
    int rows = int.Parse(Console.ReadLine()!);

    Console.Write("Введите количество столбцов числовой матрицы: ");
    int colums = int.Parse(Console.ReadLine()!);

    Console.Write("Введите минимальное значение элемента матрицы: ");
    int minValue = int.Parse(Console.ReadLine()!);

    Console.Write("Введите максимальное значение элемента матрицы: ");
    int maxValue = int.Parse(Console.ReadLine()!);
    
    int[] data = {rows, colums, minValue, maxValue};

    return data;
}


//Создает числовую матрицу 
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

int MinRows(int[,] matrix)
{
    int sumOfRowValues;
    int minRow = 1;
    int minSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sumOfRowValues = matrix[i, 0];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumOfRowValues += matrix[i, j];
        }

        if (i == 0 || minSum > sumOfRowValues)
        {
            minRow = i + 1;
            minSum = sumOfRowValues;
        }
    }
    return minRow; 
}


//Написание программы вывода матрицы с характеристиками введенными с консоли
int[] dataArray = MatrixDataInput();
int[,] matrix = NewMatrix(dataArray[0], dataArray[1], dataArray[2], dataArray[3]);
Console.Clear();
PrintMatrix(matrix, 0);
Console.WriteLine();
Console.Write($"Строка с наименьшей суммой элементов: {MinRows(matrix)}");
