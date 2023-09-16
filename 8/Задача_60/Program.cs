// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,,] CreateMatrix(int row, int col, int layer)
{
    int[,,] matrix = new int[row, col, layer];
    return matrix;
}

bool CheckNumbers(int[,,] matrix, int num)
{
    int count = 0;
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i, j, k] == num) count++;
            }
        }
    }
    return count != 0;
}

int[,,] FillMatrix(int[,,] matrix)
{
    int num = new Random().Next(10, 100);

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                while (CheckNumbers(matrix, num)) num = new Random().Next(10, 99);
                matrix[i, j, k] = num;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                System.Console.Write($"{matrix[i, j, k]} ({i}, {j}, {k})\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
        System.Console.WriteLine();
    }
}

int row = InputNum("Введите колиство рядов матрицы: ");
int col = InputNum("Введите количество строк матрицы: ");
int layer = InputNum("Введите количество слоев матрицы: ");
int[,,] matrix = CreateMatrix(row, col, layer);

if (matrix.Length > 80) 
{
    System.Console.WriteLine("Уменьшите размер матрицы");
    System.Console.WriteLine("Количество элементов матрицы не должно "
                                + "превышать 90 элементов");
}
else
{
    matrix = FillMatrix(matrix);
    System.Console.WriteLine();
    PrintMatrix(matrix);
    System.Console.WriteLine(); 
}