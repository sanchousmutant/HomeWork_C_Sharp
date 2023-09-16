// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}


int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rnd.Next(10);
        }
    }
    return matrix;
}

void PrintElementSearch(int[,] matrix, int rowPosition, int columnPosition)
{
    if (rowPosition > matrix.GetLength(0) || columnPosition > matrix.GetLength(1))
        System.Console.WriteLine("Такого числа нет");
    else
        System.Console.WriteLine($"Искомое число: {matrix[rowPosition - 1, columnPosition - 1]}");
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"  {matrix[i, j]}");
        }
        System.Console.WriteLine();
    }
}

int m = InputNum("Введите число строк: ");
int n = InputNum("Введите число столбцов: ");
int[,] matrix = CreateMatrix(m, n);
System.Console.WriteLine();
PrintMatrix(matrix);
System.Console.WriteLine();
int rowPosition = InputNum("Введите номер ряды: ");
int columnPosition = InputNum("Введите номер столбца: ");
PrintElementSearch(matrix, rowPosition, columnPosition);
System.Console.WriteLine();