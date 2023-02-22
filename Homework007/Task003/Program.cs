// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

    int[] data = { rows, colums, minValue, maxValue };

    return data;
}


// Создает числовую матрицу 
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


// Нахождение среднего арифметического
double[] ArithmetiсMean(int[,] matrix)
{
    double[] meanArray = new double[matrix.GetLength(1)];
    double mean;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        mean = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            mean += matrix[i, j];
        }
        mean = mean / matrix.GetLength(0);
        meanArray[i] = mean;
    }
    return meanArray;
}


// Выводит в консоль матрицу и среднее арифметическое элементов в каждом столбце.
void PrintMatrix(int[,] matrix, double[] meanArray)
{
    int count = 1;
    int length = 3;
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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        leftPosition = i * (length + 1);
        if (meanArray[i] >= 0) leftPosition++;
        Console.SetCursorPosition(leftPosition, matrix.GetLength(0) + 1);
        // Console.Write($"{meanArray[i]: F2} ");
        Console.Write("{0:0.0}", meanArray[i]);
    }
}


int[] dataArray = MatrixDataInput();
int[,] matrix = NewMatrix(dataArray[0], dataArray[1], dataArray[2], dataArray[3]);
double[] arithmetiсMean = ArithmetiсMean(matrix);
PrintMatrix(matrix, arithmetiсMean);