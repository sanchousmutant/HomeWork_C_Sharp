// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и
// минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[] Array(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToDouble(rnd.Next(100, 999)/10.0);
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

void DifMaxMin(double max, double min)
{
    double dif = max - min;
    System.Console.WriteLine($"Разность максимального {max} и минимального {min} "
    + $"числа массива равна {Math.Round(dif, 2)}");
}

int size = InputNum("Введите размер массива: ");
double[] array = Array(size);
PrintArray(array);
double max = MaxInArray(array);
double min = MinInArray(array);
DifMaxMin(max, min);
