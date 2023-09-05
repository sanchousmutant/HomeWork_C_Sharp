// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и
// минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[] CreatArray(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * 10, 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

double MaxInArray(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double MinInArray(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

void DifferenceMaxMin(double max, double min)
{
    double dif = max - min;
    System.Console.WriteLine("Разность максимального и минимального "
                            + $"числа массива равна {max} - {min}"
                            + $" = {Math.Round(dif, 2)}");
}

int size = InputNum("Введите размер массива: ");
double[] array = CreatArray(size);
PrintArray(array);
double max = MaxInArray(array);
double min = MinInArray(array);
DifferenceMaxMin(max, min);
