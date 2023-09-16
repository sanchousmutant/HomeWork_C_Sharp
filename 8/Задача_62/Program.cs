// Задача 62: Заполните спирально массив 4 на 4.

int[,] CreateMatrix()
{
    int[,] matrix = new int[4, 4];
    return matrix;
}


void NumbersAscendingSpiral(int[,] matrix)
{
    int num = 1;

// направо
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        matrix[0, i] = num;
        num++;
    }
// вниз 
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        matrix[matrix.GetLength(0) - 3 + i, matrix.GetLength(1) - 1] = num;
        num++;
    }
// налево 
    for (int i = 0; i < matrix.GetLength(1) - 1; i++)
    {
        matrix[matrix.GetLength(0) - 1, (matrix.GetLength(1) - 1) - 1 - i] = num;
        num++;
    }
// вверх 
    for (int i = 0; i < matrix.GetLength(0) - 2; i++)
    {
        matrix[matrix.GetLength(0) - 2 - i, 0] = num;
        num++;
    }
// направо    
    for (int i = 0; i < matrix.GetLength(1) - 2; i++)
    {
        matrix[matrix.GetLength(0) - 3, matrix.GetLength(1) - 3 + i] = num;
        num++;
    }
// вниз 
    for (int i = 0; i < matrix.GetLength(0) - 3; i++)
    {
        matrix[(matrix.GetLength(0) - 2) + i, matrix.GetLength(1) - 2] = num;
        num++;
    }
// налево 
    for (int i = 0; i < matrix.GetLength(1) - 3; i++)
    {
        matrix[matrix.GetLength(0) - 2, matrix.GetLength(1) - 3 - i] = num;
        num++;
    } 
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}



int[,] matrix = CreateMatrix();
System.Console.WriteLine();
NumbersAscendingSpiral(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();