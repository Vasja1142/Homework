// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

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
double[,] NewMatrix(int rows, int colums, int minValue, int maxValue)
{
    double[,] matrix = new double[rows, colums];
    double num;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            num = new Random().Next(minValue * 100, maxValue * 100 + 1);
            matrix[i, j] = num / 100;
        }
    }
    return matrix;
}


//Выводит в консоль матрицу
void PrintMatrix(double[,] matrix)
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

int[] dataArray = MatrixDataInput();
double[,] matrix = NewMatrix(dataArray[0], dataArray[1], dataArray[2], dataArray[3]);
PrintMatrix(matrix);