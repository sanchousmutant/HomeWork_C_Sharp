// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        array[i] = new Random().Next(1, 30);
    }
    return array;
}

void SumEven(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    System.Console.Write("Сумма чисел массива ");
    System.Console.Write("[{0}]", string.Join(", ", array));
    System.Console.WriteLine($", стоящих на нечетных позициях, равна {sum}");
}


int size = InputNum("Введите размер массива: ");
int[] array = Array(size);
SumEven(array);