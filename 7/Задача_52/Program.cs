// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое
// каждого столбца: 4,6; 5,6; 3,6; 3.

int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}


int[,] CreatArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(10);
        }
    }
    return array;
}

void ArithmeticalMean(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        System.Console.Write($"{Math.Round(sum * Math.Pow(array.GetLength(1), -1), 2)}; ");
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int m = InputNum("Введите число строк: ");
int n = InputNum("Введите число столбцов: ");
int[,] array = CreatArray(m, n);
System.Console.WriteLine();
PrintArray(array);
System.Console.WriteLine();
ArithmeticalMean(array);
System.Console.WriteLine();