// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] CreateMatrix(int row, int col)
{
    int[,] matrix = new int[4, new Random().Next(row, col)];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(10);
        }
    }
    return matrix;
}

int[] SumNumbersRow(int[,] matrix)
{
    int[] sumNumRow = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[i, j];
        }
        sumNumRow[i] = sum;
    }
    return sumNumRow;
}

void MinSumNumbersRow(int[] sumNumRow)
{
    int minNum = sumNumRow[0];
    int row = 0;
    
    for (int i = 1; i < sumNumRow.Length; i++)
    {
        if (minNum > sumNumRow[i]) 
        {
            minNum = sumNumRow[i];
            row = i;
        }
    }
    System.Console.WriteLine($"Строка с минимальной суммой чисел: {row + 1}");
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

int[] sumNumRow = SumNumbersRow(matrix);
MinSumNumbersRow(sumNumRow);
System.Console.WriteLine();
