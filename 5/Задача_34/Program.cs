// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами.
// Напишите программу, которая покажет
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] Array(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void NumberEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    System.Console.Write("Колличество четных чисел массива ");
    System.Console.Write("[{0}]", string.Join(", ", array));
    System.Console.WriteLine($" равно {count}");
}

int size = InputNum("Введите размер массива : ");
int[] array = Array(size);
NumberEven(array);