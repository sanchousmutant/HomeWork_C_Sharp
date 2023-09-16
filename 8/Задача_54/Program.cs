// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

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
            matrix[i,j] = rnd.Next(20);
        }
    }
    return matrix;
}

void NambersRowAscendigOrder(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k - 1] < matrix[i, k]) (matrix[i, k - 1], matrix[i, k]) = (matrix[i, k], matrix[i, k - 1]);
            }
        }
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

int row = InputNum("Введите колиство рядов матрицы: ");
int col = InputNum("Введите количество строк матрицы: ");
int[,] matrix = CreateMatrix(row, col);
System.Console.WriteLine();
PrintMatrix(matrix);
System.Console.WriteLine();
NambersRowAscendigOrder(matrix);
PrintMatrix(matrix);