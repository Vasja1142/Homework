// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

//Ввод характеристики матрицы через консоль
int[] MatrixDataInput(string num)
{
    Console.Clear();

    Console.Write($"Введите количество строк {num} числовой матрицы: ");
    int rows = int.Parse(Console.ReadLine()!);

    Console.Write($"Введите количество столбцов {num} числовой матрицы: ");
    int colums = int.Parse(Console.ReadLine()!);

    Console.Write($"Введите минимальное значение {num} элемента матрицы: ");
    int minValue = int.Parse(Console.ReadLine()!);

    Console.Write($"Введите максимальное значение {num} элемента матрицы: ");
    int maxValue = int.Parse(Console.ReadLine()!);

    int[] data = { rows, colums, minValue, maxValue };

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

// Рассчитывает произведение матриц
int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
{
    int Product(int[,] matrix1, int[,] matrix2, int rows, int colums, int num)
    {
        int product = 0;
        if (matrix1.GetLength(1) == num) return product;
        else
        {
            return product = matrix1[rows, num] * matrix2[num, colums] + Product(matrix1, matrix2, rows, colums, num + 1);
        }
    }



    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = Product(matrix1, matrix2, i, j, 0);
        }
    }
    return result;
}


// Выводит в консоль матрицу
void PrintMatrix(int[,] matrix, int upPosition, int leftPosition2)
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
    int leftPosition1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            leftPosition1 = j * (length + 1);
            if (matrix[i, j] >= 0) leftPosition1++;
            Console.SetCursorPosition(leftPosition1 + leftPosition2, i + upPosition);
            Console.Write($"{matrix[i, j]} ");
        }
    }
}

int[] dataArray1 = MatrixDataInput("первой");
int[,] matrix1 = NewMatrix(dataArray1[0], dataArray1[1], dataArray1[2], dataArray1[3]);
int[] dataArray2 = MatrixDataInput("второй");
int[,] matrix2 = NewMatrix(dataArray2[0], dataArray2[1], dataArray2[2], dataArray2[3]);
int[,] result = MatrixProduct(matrix1, matrix2);

Console.Clear();

Console.WriteLine("Первая матрица");
PrintMatrix(matrix1, 1, 0);
Console.SetCursorPosition(0, dataArray1[0] + 2);
Console.WriteLine("Вторая матрица");
PrintMatrix(matrix2, dataArray1[0] + 3, 0);
Console.SetCursorPosition(0, dataArray1[0] + dataArray2[0] + 4);
if (dataArray1[1] == dataArray2[0])
{
    Console.WriteLine("Произведение матриц");
    PrintMatrix(result, dataArray1[0] + dataArray2[0] + 5, 0);
}
else Console.WriteLine("Количество столбцов первой матрицы не совпадает с количеством строк второй");
