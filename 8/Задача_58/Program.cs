// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] CreateMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

int[,] ProductTwoMatrix(int[,] matrixFirst, int[,] matrixSecond)
{
        int row = matrixFirst.GetLength(0);
        int col = matrixSecond.GetLength(1);
        int[,] prodMatrix = new int[row, col];
        int prod = 0;

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                for (int k = 0; k < col; k++)
                {
                    prod += matrixFirst[i, k] * matrixSecond[k, j];
                }
                    prodMatrix[i, j] = prod;
                    prod = 0;
                }
        }
        return prodMatrix;
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

int row = InputNum("Введите количество рядов матрицы: ");
int col = InputNum("Введите количество столбцов матрицы: ");
int[,] firstMatrix = CreateMatrix(row, col);
System.Console.WriteLine();

System.Console.WriteLine("Необходимо ввести параметры для второй матрицы");
System.Console.WriteLine();

row = InputNum("Введите количество рядов матрицы: ");
col = InputNum("Введите количество столбцов матрицы: ");
int[,] secondMatrix = CreateMatrix(row, col);
System.Console.WriteLine();

if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
    System.Console.WriteLine("Количество элементов строки первой матрицы должно совпадать с " 
    + "количеством элементов столбца второй матрицы");
else    
{
    PrintMatrix(firstMatrix);
    System.Console.WriteLine();
    PrintMatrix(secondMatrix);
    System.Console.WriteLine();

    int[,] prodMatrix = ProductTwoMatrix(firstMatrix, secondMatrix);
    PrintMatrix(prodMatrix);
    System.Console.WriteLine();
}