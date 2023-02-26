// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] NewMatrix()
{
    int[,] matrix = new int[4, 4];
    int num = 1;
    
    for (int i = 0; i < 4; i++)
    {
        matrix[0, i] = num++;
    }

    for (int i = 1; i < 4; i++)
    {
        matrix[i, 3] = num++;
    }
    
    for (int i = 2; i >= 0; i--)
    {
        matrix[3, i] = num++;
    }

    for (int i = 2; i >= 1; i--)
    {
        matrix[i, 0] = num++;
    }
    
    for (int i = 1; i <= 2; i++)
    {
        matrix[1, i] = num++;
    }

    for (int i = 2; i >= 1; i--)
    {
        matrix[2, i] = num++;
    }
    return matrix;
}

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

Console.Clear();
PrintMatrix(NewMatrix(), 0);